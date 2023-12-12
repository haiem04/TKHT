using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using TKHT.DTO;
using TKHT.PControl;
using TKHT.PUtil;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TKHT.PView
{
    public partial class FHistory : Form
    {
        private List<DTOCustomzieTest> listDTOCustomzieTest = new List<DTOCustomzieTest>();
        public FHistory()
        {
            InitializeComponent();
            dgvHistory.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvHistory.AutoGenerateColumns = false;
            loadData();


        }
        private void loadData()
        {
            listDTOCustomzieTest = ControlAttempt.getTestByStudentAttemp();
            dgvHistory.DataSource = listDTOCustomzieTest;
        }

        private void KhoaSV_Click(object sender, EventArgs e)
        {

        }

        private void dgvHistory_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridView dgv = sender as DataGridView;

                int idColumnIndex = dgv.Columns["AttemptID"].Index; 

                var idValue = dgv.Rows[e.RowIndex].Cells[idColumnIndex].Value;
                int idColumnIndex1 = dgv.Columns["Date"].Index;

                var idValue1 = dgv.Rows[e.RowIndex].Cells[idColumnIndex1].Value;
                int idColumnIndex2 = dgv.Columns["Name"].Index;

                var idValue2 = dgv.Rows[e.RowIndex].Cells[idColumnIndex2].Value;

                FResultOfTest f = new FResultOfTest(int.Parse(idValue.ToString()), idValue1.ToString(), idValue2.ToString());
                f.Show();
            }
        }

        private void lietkehvBTN_Click(object sender, EventArgs e)
        {
            listDTOCustomzieTest.OrderByDescending(x => x.Date);
            dgvHistory.DataSource = listDTOCustomzieTest;

        }

        private void dgvHistory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridView dgv = sender as DataGridView;

                int idColumnIndex = dgv.Columns["AttemptID"].Index;
                var idValue = dgv.Rows[e.RowIndex].Cells[idColumnIndex].Value;

                var obj = listDTOCustomzieTest.FirstOrDefault(x => x.AttemptId.ToString() == idValue.ToString());
                tbSubject.Text = obj.Subject;
                tbLoai.Text = obj.Type;
                dpDate.Value = obj.Date.Value;


            }
        }

        private void timKiemHVBTN_Click(object sender, EventArgs e)
        {
            handleSearch();
        }

        private void tbFind_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                handleSearch();
            }
        }
        private void handleSearch()
        {
            string vFind = tbFind.Text;
            if (String.IsNullOrEmpty(vFind))
            {
                dgvHistory.DataSource = listDTOCustomzieTest;
                return;
            }
            bool containsNumber = Regex.IsMatch(vFind, @"\d");
            var newList = containsNumber ? listDTOCustomzieTest.Where(x => x.Date.ToString().Contains(vFind)).ToList() : listDTOCustomzieTest.Where(x => x.Subject.Contains(vFind.ToLower())).ToList();
            dgvHistory.DataSource = newList;
        }

        private void manageAccountsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void managerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FAdmin f = new FAdmin();
            f.Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FLogin f = new FLogin();
            GlobalVar.studentInfo = null;
            f.Show();
        }
    }
}
