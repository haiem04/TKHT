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
    public partial class FAdmin : Form
    {
        BindingList<DTOStudent> listStudent = new BindingList<DTOStudent>();
        public static TKHTEntities1 db = new TKHTEntities1();
        public FAdmin()
        {
            InitializeComponent();
            loadDSHocVien();
            loadDSLop();

            string[] genderOptions = new string[] { "", "F", "M" };

            // Bind the array to the ComboBox
            cbSex.DataSource = genderOptions;

            // Optionally, set the selected index to 0 to display the empty value by default
            cbSex.SelectedIndex = 0;
        }



        void loadDSHocVien()
        {
            var list = ControlHocVien.findAll();
            dgvStudentList.DataSource = list;
        }

        void loadDSLop()
        {
            var classes = ControlClass.FindAll();
            cbLop.DataSource = classes;
            cbLop.DisplayMember = "Name";
            cbLop.ValueMember = "id";
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.Hide();
            FHistory f = new FHistory();
            f.Show();
        }

        private void FAdmin_Load(object sender, EventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void dgvStudentList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0 && e.RowIndex >= 0)
            {
                DataGridView dgv = sender as DataGridView;

                if (dgv != null)
                {
                    DataGridViewCell id = dgv.Rows[e.RowIndex].Cells[0];
                    DataGridViewCell name = dgv.Rows[e.RowIndex].Cells[1];
                    DataGridViewCell address = dgv.Rows[e.RowIndex].Cells[2];
                    DataGridViewCell phone = dgv.Rows[e.RowIndex].Cells[3];
                    DataGridViewCell sex = dgv.Rows[e.RowIndex].Cells[4];
                    DataGridViewCell className = dgv.Rows[e.RowIndex].Cells[5];


                    txtStudentName.Text = name?.Value.ToString();
                    txtAddress.Text = address?.Value.ToString();
                    txtPhone.Text = phone?.Value.ToString();
                    cbSex.SelectedValue = sex?.Value.ToString();
                    cbLop.SelectedValue = className?.Value.ToString();
                }
            }
        }

        private void dgvStudentList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0 && e.RowIndex >= 0)
            {
                DataGridView dgv = sender as DataGridView;

                if (dgv != null)
                {
                    DataGridViewCell id = dgv.Rows[e.RowIndex].Cells[0];
                    DataGridViewCell name = dgv.Rows[e.RowIndex].Cells[1];
                    DataGridViewCell address = dgv.Rows[e.RowIndex].Cells[2];
                    DataGridViewCell phone = dgv.Rows[e.RowIndex].Cells[3];
                    DataGridViewCell sex = dgv.Rows[e.RowIndex].Cells[4];
                    DataGridViewCell className = dgv.Rows[e.RowIndex].Cells[5];

                    txtStudentName.Text = name?.Value?.ToString() ?? "";
                    txtAddress.Text = address?.Value?.ToString() ?? "";
                    txtPhone.Text = phone?.Value?.ToString() ?? "";

                    // Correctly set the selected item for the ComboBox
                    cbSex.SelectedItem = sex?.Value?.ToString() ?? "";

                    // Handle cbLop similarly, assuming it's set up in a compatible way
                    cbLop.SelectedValue = className?.Value.ToString();
                }
            }
        }

        private void btnThem(object sender, EventArgs e)
        {
            Student st = new Student
            {
                Name = txtStudentName.Text,
                Address = txtAddress.Text,
                Phone = txtPhone.Text,
                Sex = cbSex.SelectedValue.ToString(),
                ClassId = int.Parse(cbLop.SelectedValue.ToString())
            };
            Debug.WriteLine($"MaMH: {st.Name}, MaKhoa: {st.Address}, TenMH: {st.Phone}, SoTinChi: {st.Sex}, cc: {st.ClassId}");
            ControlHocVien.Add(st);
            loadDSHocVien();
            resetText();

        }


        public void resetText()
        {
            txtStudentName.Text = "";
            txtAddress.Text = "";
            txtPhone.Text = "";
            cbSex.SelectedIndex = 0;
            cbLop.SelectedValue = "";
        }

        private void huyDangKyBTN_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Chắc chắn muốn xóa môn học?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dialogResult == DialogResult.Yes)
            {
                int index = dgvStudentList.CurrentCell.RowIndex;
                string mast = dgvStudentList.Rows[index].Cells[0].Value + "";
                ControlHocVien.Delete(ControlHocVien.FindSV(mast));
                resetText();
                loadDSHocVien();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Chắc chắn muốn cập nhật môn học?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dialogResult == DialogResult.Yes)
            {
                int index = dgvStudentList.CurrentCell.RowIndex;
                string mast = dgvStudentList.Rows[index].Cells[0].Value + "";
                Student st = ControlHocVien.FindSV(mast);
                st.id = st.id;
                st.Name = txtStudentName.Text;
                st.Address = txtAddress.Text;
                st.Phone = txtPhone.Text;
                st.ClassId = int.Parse(cbLop.SelectedValue.ToString());
                ControlHocVien.Update(st);
                loadDSHocVien();

            }
        }
    }
}
