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
using TKHT.DTO;
using TKHT.PControl;

namespace TKHT.PView
{
    public partial class FHistory : Form
    {
        public FHistory()
        {
            InitializeComponent();
            dgvHistory.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvHistory.AutoGenerateColumns = false;
            loadData();


        }
        private void loadData()
        {
            dgvHistory.DataSource = ControlAttempt.getTestByStudentAttemp()?? new List<DTOCustomzieTest>();
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

                FResultOfTest f = new FResultOfTest(int.Parse(idValue.ToString()), idValue1.ToString());
                f.Show();
            }
        }
    }
}
