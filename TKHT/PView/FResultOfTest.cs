using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TKHT.PControl;

namespace TKHT.PView
{
    public partial class FResultOfTest : Form
    {
        public int attemptId;
        public string date;
        public string fName;
        private List<DTO.DTOCustomizeAttemptQuestion> list = new List<DTO.DTOCustomizeAttemptQuestion>();
        public FResultOfTest(int attemptId, string date, string name)
        {
            InitializeComponent();
            this.attemptId = attemptId;
            this.date = date;
            this.fName = name;
            dgvAttemptQestion.AutoGenerateColumns = false;
            dgvAttemptQestion.EditMode = DataGridViewEditMode.EditProgrammatically;
            load();
        }
        private void load()
        {
            label1.Text = $"Kết quả của bài kiểm tra {date}";
            list = ControlAttempt.getResultOfTest(attemptId);
            int mark = list.Count(x => x.Answer == x.CorrectAnswer);
            diemkq.Text = $"Kết quả: {mark}/{list.Count()}";
            name.Text = $"Tên bài kiểm tra: {fName}";
            dgvAttemptQestion.DataSource = list;
        }

        private void FResultOfTest_Load(object sender, EventArgs e)
        {

        }

        private void dgvAttemptQestion_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
