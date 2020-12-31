using Lab03_01.Model;
using Lab03_01.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab03_01
{
    public partial class frmFaculty : Form
    {
        public frmFaculty()
        {
            InitializeComponent();
            LoadData();
        }
        private void LoadData()
        {
            BindGrid(StudentManageService.GetFaculty());
        }

        private Faculty AddUpdate()
        {
            Faculty faculty = new Faculty();
            faculty.FacultyID = int.Parse(txtBoxNumber.Text);
            faculty.FacultyName = txtBoxFaculty.Text;
            if (txtBoxNumPro.Text == "")
                faculty.TotalProfessor = null;
            else
            {
                faculty.TotalProfessor = int.Parse(txtBoxNumPro.Text);
            }
            return faculty;
        }

        private void BindGrid(List<Faculty> listFaculty)
        {
            dgvFaculty.Rows.Clear();
            foreach (var item in listFaculty)
            {
                int index = dgvFaculty.Rows.Add();
                dgvFaculty.Rows[index].Cells[0].Value = item.FacultyID;
                dgvFaculty.Rows[index].Cells[1].Value = item.FacultyName;
                dgvFaculty.Rows[index].Cells[2].Value = item.TotalProfessor;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateItem())
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!StudentManageService.ValidateFaculty(int.Parse(txtBoxNumber.Text)))
            {
                StudentManageService.EditFaculty(AddUpdate());
                MessageBox.Show("Sửa dữ liệu thành công!", "Sửa dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
                return;
            }
            StudentManageService.AddFaculty(AddUpdate());
            MessageBox.Show("Thêm dữ liệu thành công!", "Thêm dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadData();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvFaculty_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var rows = this.dgvFaculty.Rows[e.RowIndex];
            txtBoxNumber.Text = rows.Cells[0].Value.ToString();
            txtBoxFaculty.Text = rows.Cells[1].Value.ToString();
            if (rows.Cells[2].Value == null)
            {
                txtBoxNumPro.Text = "";
            }
            else
            {
                txtBoxNumPro.Text = rows.Cells[2].Value.ToString();
            }
        }
        private bool ValidateItem()
        {
            if (string.IsNullOrEmpty(txtBoxNumber.Text) ||
                string.IsNullOrEmpty(txtBoxFaculty.Text))
            {
                return false;
            }
            foreach (var item in txtBoxNumber.Text)
            {
                if (!char.IsDigit(item))
                    return false;
            }
            foreach (var item in txtBoxNumPro.Text)
            {
                if (!char.IsDigit(item))
                    return false;
            }
            return true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            StudentManageService.DeleteFaculty(int.Parse(txtBoxNumber.Text));
            LoadData();
        }
    }
}
