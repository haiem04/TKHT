using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Windows.Forms;
using TKHT.PControl;

namespace TKHT.PView
{
    public partial class FTest : Form
    {
        public int testId { get; set; }
        public int studentId { get; set; }
        private List<Question> questions = new List<Question> { };
        private List<Panel> questionPanels = new List<Panel>();
        private int timeRemainingInSeconds ; 
        private int page = 0;
        private const int QuestionsPerPage = 4;
        private  Attempt attempt;

        // Dictionary to store selected answers for each question
        private Dictionary<int, string> selectedAnswers = new Dictionary<int, string>();

        public FTest(int _testId, int _studentId)
        {   
            InitializeComponent();
            questions = ControlQuestion.getQuestionsByTestId(_testId);
            pageNumberTxt.Text = "1";
            testId = _testId;
            studentId = _studentId;
            attempt = ControlAttempt.createAttempt(studentId, testId);
        }

        private void FTest_Load(object sender, EventArgs e)
        {
            // Load the first set of questions
            LoadQuestionsForPage(page);
        }

        private void LoadQuestionsForPage(int currentPage)
        {
            // Clear existing question panels
            ClearQuestionPanels();

            // Loop through QuestionsPerPage number of questions and create panels
            for (int i = 0; i < QuestionsPerPage && (currentPage * QuestionsPerPage + i) < questions.Count; i++)
            {
                Panel questionPanel = new Panel();
                questionPanel.Size = new Size(345, 156);

                // Calculate X and Y coordinates based on the position within the current page
                int x = (i % 2) * (questionPanel.Width + 10);
                int y = (i / 2) * (questionPanel.Height + 10);

                questionPanel.Location = new Point(x, y);
                questionPanel.Controls.Add(CreateRadioButton(questions[currentPage * QuestionsPerPage + i], currentPage, i, 0, 54));

                TextBox questionTitle = new TextBox();
                questionTitle.BackColor = Color.FromArgb(39, 59, 122);
                questionTitle.BorderStyle = BorderStyle.None;
                questionTitle.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
                questionTitle.ForeColor = Color.White;
                questionTitle.Location = new Point(11, 2);
                questionTitle.Multiline = true;
                questionTitle.Name = "questionTitle";
                questionTitle.Size = new Size(256, 48);
                questionTitle.Text = questions[currentPage * QuestionsPerPage + i].QuestionText;

                questionPanel.Controls.Add(questionTitle);
                questionPanels.Add(questionPanel);
                panel1.Controls.Add(questionPanel);

                // Restore saved answers for the current page
                int storedQuestionIndex = currentPage * QuestionsPerPage + i;
                if (selectedAnswers.ContainsKey(storedQuestionIndex))
                {
                    string selectedAnswerText = selectedAnswers[storedQuestionIndex];

                    Panel currentPanel = questionPanels[i];
                    foreach (Control control in currentPanel.Controls)
                    {   
                        if (control is Panel)
                        {
                            foreach (Control _control in control.Controls)
                            {
                                if (_control is RadioButton radioButton && radioButton.Text == selectedAnswerText)
                                {
                                    radioButton.Checked = true;
                                    break;
                                }
                            }
                                
                        }
                        
                    }
                }
            }
        }


        private Panel CreateRadioButton(Question question, int currentPage, int questionIndex, int xOffset, int yOffset)
        {
            Panel radioButtonPanel = new Panel();
            radioButtonPanel.Location = new Point(11, yOffset); // Fixed yOffset for the entire panel

            string[] answerTexts = { question.AnswerA, question.AnswerB, question.AnswerC, question.AnswerD };

            for (int i = 0; i < answerTexts.Length; i++)
            {
                RadioButton radioButton = new RadioButton();
                radioButton.AutoSize = true;
                radioButton.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
                radioButton.ForeColor = SystemColors.ButtonHighlight;
                radioButton.Location = new Point(0, i * 25); // Adjusted the position relative to the panel
                radioButton.Tag = currentPage * QuestionsPerPage + i;
                radioButton.Size = new Size(100, 21);
                radioButton.TabStop = true;
                radioButton.Text = answerTexts[i];
                radioButton.UseVisualStyleBackColor = true;

                radioButton.CheckedChanged += (s, e) =>
                {
                    if (radioButton.Checked)
                    {
                        // Update the dictionary with the selected answer
                        selectedAnswers[(currentPage * QuestionsPerPage) + questionIndex] = radioButton.Text;
                    }
                };

                radioButtonPanel.Controls.Add(radioButton);
            }

            return radioButtonPanel;
        }

        private void ClearQuestionPanels()
        {
            foreach (Panel panel in questionPanels)
            {
                panel.Dispose();
            }
            questionPanels.Clear();
        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            int totalPages = (int)Math.Ceiling((double)questions.Count / QuestionsPerPage);

            if (page < totalPages - 1)
            {
                page++;
                LoadQuestionsForPage(page);
                pageNumberTxt.Text = (page + 1).ToString();
            }
            else
            {
                MessageBox.Show("You've reached the last page.");
            }
        }

        private void prevBtn_Click(object sender, EventArgs e)
        {
            page = Math.Max(0, page - 1);
            if (page >= 0)
            {
                LoadQuestionsForPage(page);
            }
            pageNumberTxt.Text = (page + 1).ToString();
        }



        private void submitTestButtonClick(object sender, EventArgs e)
        {
            submitAttempt();
        }

        public void submitAttempt()
        {
            countdownTimer.Stop();
            List<string> answers = selectedAnswers.Values.ToList();
            ControlAttempt.createAttemptQuestion(attempt, questions, answers);
            MessageBox.Show("Test attempt submitted!");

            List<string> orderedList = new List<string>();
            for (int key = 1; key <= questions.Count; key++)
            {
                if (selectedAnswers.TryGetValue(key, out string value))
                {
                    orderedList.Add(value);
                }
                else
                {
                    orderedList.Add("");
                }
            }
            this.Hide();
            FTestSelect f = new FTestSelect();
            f.Show();
        }

        private void timeLeft_TextChanged(object sender, EventArgs e)
        {
            Console.WriteLine(timeLeft.Text);
            if (timeLeft.Text == "00:00")
            {
                submitAttempt();
            }
        }
    }
}
