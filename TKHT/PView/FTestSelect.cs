using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TKHT.DTO;
using TKHT.PControl;
using TKHT.PUtil;

namespace TKHT.PView
{
    public partial class FTestSelect : Form
    {

        public FTestSelect()
        {
            InitializeComponent();
            loadComboBox();
            dgvTests.EditMode = DataGridViewEditMode.EditProgrammatically;

        }

        private void DienthoaiSV_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void loadComboBox()
        {
            List<DTOSubject> subjects = ControlSubject.getSubjectsByClassId((int)GlobalVar.studentInfo.ClassId);
            comboBox1.DataSource = subjects;
            comboBox1.DisplayMember = "SubjectName";
            comboBox1.ValueMember = "id";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
            
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                // Get the selected subject ID from the ComboBox
                int selectedSubjectId = ((DTOSubject)comboBox1.SelectedItem).id;

                // Call the method to get tests by subject ID
                List<DTO.DTOTest> tests = ControlTest.getTestsBySubjectId(selectedSubjectId);

                // Update the DataGridView with the test results
                dgvTests.DataSource = tests;
            }
        }

        private void dgvTests_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedTestId = Convert.ToInt32(dgvTests.Rows[e.RowIndex].Cells["id"].Value);
            this.Hide();
            FTest f = new FTest((int)selectedTestId, (int)GlobalVar.studentInfo.id);
            f.Show();

        }

        private void managerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FAdmin f = new FAdmin();
            f.Show();
        }

        private void manageAccountsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FLogin f = new FLogin();
            GlobalVar.studentInfo = null;
            f.Show();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.Hide();
            FAdmin f = new FAdmin();
            f.Show();
        }
    }
}
