using System.Windows.Forms;
using System;

namespace TKHT.PView
{
    partial class FTest
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        /// 
        private void CountdownTimer_Tick(object sender, EventArgs e)
        {
            if (timeRemainingInSeconds > 0)
            {
                timeRemainingInSeconds--;

                // Convert seconds to mm:ss format
                int minutes = timeRemainingInSeconds / 60;
                int seconds = timeRemainingInSeconds % 60;

                timeLeft.Text = $"{minutes:00}:{seconds:00}";
            }
            else
            {
                // Handle when the time is up
                countdownTimer.Stop();
                timeLeft.Text = "00:00";
                MessageBox.Show("Time is up!");
            }
        }

        private void InitializeComponent()
        {
            countdownTimer = new System.Windows.Forms.Timer();
            countdownTimer.Interval = 1000; // 1 second
            countdownTimer.Tick += CountdownTimer_Tick;
            countdownTimer.Start();

            this.components = new System.ComponentModel.Container();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.questionPanel = new System.Windows.Forms.Panel();
            this.asnwerD = new System.Windows.Forms.RadioButton();
            this.questionTitle = new System.Windows.Forms.TextBox();
            this.asnwerC = new System.Windows.Forms.RadioButton();
            this.answerB = new System.Windows.Forms.RadioButton();
            this.answerA = new System.Windows.Forms.RadioButton();
            this.prevBtn = new System.Windows.Forms.Button();
            this.nextBtn = new System.Windows.Forms.Button();
            this.pageNumberTxt = new System.Windows.Forms.Button();
            this.submitTestBtn = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.timeLeft = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.questionPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // countdownTimer
            // 
            this.countdownTimer.Enabled = true;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(28)))), ((int)(((byte)(104)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(240, 20);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(292, 30);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "BÀI THI";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(122)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.questionPanel);
            this.panel1.Location = new System.Drawing.Point(9, 81);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(766, 395);
            this.panel1.TabIndex = 1;
            // 
            // questionPanel
            // 
            this.questionPanel.Controls.Add(this.asnwerD);
            this.questionPanel.Controls.Add(this.questionTitle);
            this.questionPanel.Controls.Add(this.asnwerC);
            this.questionPanel.Controls.Add(this.answerB);
            this.questionPanel.Controls.Add(this.answerA);
            this.questionPanel.Location = new System.Drawing.Point(3, 3);
            this.questionPanel.Name = "questionPanel";
            this.questionPanel.Size = new System.Drawing.Size(345, 156);
            this.questionPanel.TabIndex = 0;
            this.questionPanel.Visible = false;
            // 
            // asnwerD
            // 
            this.asnwerD.AutoSize = true;
            this.asnwerD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.asnwerD.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.asnwerD.Location = new System.Drawing.Point(11, 128);
            this.asnwerD.Margin = new System.Windows.Forms.Padding(2);
            this.asnwerD.Name = "asnwerD";
            this.asnwerD.Size = new System.Drawing.Size(56, 21);
            this.asnwerD.TabIndex = 7;
            this.asnwerD.TabStop = true;
            this.asnwerD.Text = "D. 4";
            this.asnwerD.UseVisualStyleBackColor = true;
            // 
            // questionTitle
            // 
            this.questionTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(59)))), ((int)(((byte)(122)))));
            this.questionTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.questionTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questionTitle.ForeColor = System.Drawing.Color.White;
            this.questionTitle.Location = new System.Drawing.Point(11, 2);
            this.questionTitle.Margin = new System.Windows.Forms.Padding(2);
            this.questionTitle.Multiline = true;
            this.questionTitle.Name = "questionTitle";
            this.questionTitle.Size = new System.Drawing.Size(256, 48);
            this.questionTitle.TabIndex = 3;
            this.questionTitle.Text = "Câu 1: 2+2 = mấy?";
            // 
            // asnwerC
            // 
            this.asnwerC.AutoSize = true;
            this.asnwerC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.asnwerC.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.asnwerC.Location = new System.Drawing.Point(11, 103);
            this.asnwerC.Margin = new System.Windows.Forms.Padding(2);
            this.asnwerC.Name = "asnwerC";
            this.asnwerC.Size = new System.Drawing.Size(55, 21);
            this.asnwerC.TabIndex = 6;
            this.asnwerC.TabStop = true;
            this.asnwerC.Text = "C. 3";
            this.asnwerC.UseVisualStyleBackColor = true;
            // 
            // answerB
            // 
            this.answerB.AutoSize = true;
            this.answerB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answerB.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.answerB.Location = new System.Drawing.Point(11, 79);
            this.answerB.Margin = new System.Windows.Forms.Padding(2);
            this.answerB.Name = "answerB";
            this.answerB.Size = new System.Drawing.Size(55, 21);
            this.answerB.TabIndex = 5;
            this.answerB.TabStop = true;
            this.answerB.Text = "B. 2";
            this.answerB.UseVisualStyleBackColor = true;
            // 
            // answerA
            // 
            this.answerA.AutoSize = true;
            this.answerA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answerA.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.answerA.Location = new System.Drawing.Point(11, 54);
            this.answerA.Margin = new System.Windows.Forms.Padding(2);
            this.answerA.Name = "answerA";
            this.answerA.Size = new System.Drawing.Size(55, 21);
            this.answerA.TabIndex = 4;
            this.answerA.TabStop = true;
            this.answerA.Text = "A. 1";
            this.answerA.UseVisualStyleBackColor = true;
            // 
            // prevBtn
            // 
            this.prevBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(28)))), ((int)(((byte)(104)))));
            this.prevBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prevBtn.ForeColor = System.Drawing.Color.White;
            this.prevBtn.Location = new System.Drawing.Point(327, 486);
            this.prevBtn.Margin = new System.Windows.Forms.Padding(2);
            this.prevBtn.Name = "prevBtn";
            this.prevBtn.Size = new System.Drawing.Size(32, 33);
            this.prevBtn.TabIndex = 2;
            this.prevBtn.Text = "<";
            this.prevBtn.UseVisualStyleBackColor = false;
            this.prevBtn.Click += new System.EventHandler(this.prevBtn_Click);
            // 
            // nextBtn
            // 
            this.nextBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(28)))), ((int)(((byte)(104)))));
            this.nextBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextBtn.ForeColor = System.Drawing.Color.White;
            this.nextBtn.Location = new System.Drawing.Point(419, 486);
            this.nextBtn.Margin = new System.Windows.Forms.Padding(2);
            this.nextBtn.Name = "nextBtn";
            this.nextBtn.Size = new System.Drawing.Size(32, 33);
            this.nextBtn.TabIndex = 3;
            this.nextBtn.Text = ">";
            this.nextBtn.UseVisualStyleBackColor = false;
            this.nextBtn.Click += new System.EventHandler(this.nextBtn_Click);
            // 
            // pageNumberTxt
            // 
            this.pageNumberTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(28)))), ((int)(((byte)(104)))));
            this.pageNumberTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pageNumberTxt.ForeColor = System.Drawing.Color.White;
            this.pageNumberTxt.Location = new System.Drawing.Point(374, 486);
            this.pageNumberTxt.Margin = new System.Windows.Forms.Padding(2);
            this.pageNumberTxt.Name = "pageNumberTxt";
            this.pageNumberTxt.Size = new System.Drawing.Size(32, 33);
            this.pageNumberTxt.TabIndex = 4;
            this.pageNumberTxt.Text = "1";
            this.pageNumberTxt.UseVisualStyleBackColor = false;
            // 
            // submitTestBtn
            // 
            this.submitTestBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(28)))), ((int)(((byte)(104)))));
            this.submitTestBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitTestBtn.ForeColor = System.Drawing.Color.White;
            this.submitTestBtn.Location = new System.Drawing.Point(639, 486);
            this.submitTestBtn.Margin = new System.Windows.Forms.Padding(2);
            this.submitTestBtn.Name = "submitTestBtn";
            this.submitTestBtn.Size = new System.Drawing.Size(135, 33);
            this.submitTestBtn.TabIndex = 5;
            this.submitTestBtn.Text = "Nộp bài";
            this.submitTestBtn.UseVisualStyleBackColor = false;
            this.submitTestBtn.Click += new System.EventHandler(this.submitTestButtonClick);
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(28)))), ((int)(((byte)(104)))));
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.ForeColor = System.Drawing.Color.White;
            this.textBox3.Location = new System.Drawing.Point(637, 28);
            this.textBox3.Margin = new System.Windows.Forms.Padding(2);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(83, 21);
            this.textBox3.TabIndex = 6;
            this.textBox3.Text = "Thời gian: ";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // timeLeft
            // 
            this.timeLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(28)))), ((int)(((byte)(104)))));
            this.timeLeft.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.timeLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLeft.ForeColor = System.Drawing.Color.White;
            this.timeLeft.Location = new System.Drawing.Point(712, 29);
            this.timeLeft.Margin = new System.Windows.Forms.Padding(2);
            this.timeLeft.Name = "timeLeft";
            this.timeLeft.Size = new System.Drawing.Size(62, 21);
            this.timeLeft.TabIndex = 7;
            this.timeLeft.Text = "99:99";
            this.timeLeft.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.timeLeft.TextChanged += new System.EventHandler(this.timeLeft_TextChanged);
            // 
            // FTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(28)))), ((int)(((byte)(104)))));
            this.ClientSize = new System.Drawing.Size(783, 528);
            this.Controls.Add(this.timeLeft);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.submitTestBtn);
            this.Controls.Add(this.pageNumberTxt);
            this.Controls.Add(this.nextBtn);
            this.Controls.Add(this.prevBtn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FTest";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FTest_Load);
            this.panel1.ResumeLayout(false);
            this.questionPanel.ResumeLayout(false);
            this.questionPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox questionTitle;
        private System.Windows.Forms.RadioButton asnwerD;
        private System.Windows.Forms.RadioButton asnwerC;
        private System.Windows.Forms.RadioButton answerB;
        private System.Windows.Forms.RadioButton answerA;
        private System.Windows.Forms.Button prevBtn;
        private System.Windows.Forms.Button nextBtn;
        private System.Windows.Forms.Button pageNumberTxt;
        private System.Windows.Forms.Button submitTestBtn;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox timeLeft;
        private System.Windows.Forms.Panel questionPanel;
        private System.Windows.Forms.Timer countdownTimer;
    }
}