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
        private static Student student = GlobalVar.studentInfo;


        public FTestSelect()
        {
            InitializeComponent();
            loadComboBox();
        }

        private void DienthoaiSV_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void loadComboBox()
        {
            List<DTOSubject> subjects = ControlSubject.getSubjectsByClassId(1);
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
            this.Hide();
            FTest f = new FTest();
            f.Show();
        }
    }
}
