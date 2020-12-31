using Lab03_01;
using Lab03_01.Model;
using Lab03_01.Services;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Lab02_02
{
    public partial class fQuanLySinhVien : Form
    {
        public fQuanLySinhVien()
        {
            InitializeComponent();
            LoadData();
            FillFacultyCombobox();
        }

        private void LoadData()
        {
            BindGrid(StudentManageService.GetStudent());

        }

        private void FillFacultyCombobox()
        {
            List<Faculty> list = new List<Faculty>(StudentManageService.GetFaculty());
            cBoxFaculty.DataSource = list;
            cBoxFaculty.DisplayMember = "FacultyName";
            cBoxFaculty.ValueMember = "FacultyID"; 
        }

        private void BindGrid(List<Student> listStudent)
        {
            dgvStudent.Rows.Clear();
            foreach(var item in listStudent)
            {
                int index = dgvStudent.Rows.Add();
                dgvStudent.Rows[index].Cells[0].Value = item.StudentID;
                dgvStudent.Rows[index].Cells[1].Value = item.FullName;
                dgvStudent.Rows[index].Cells[2].Value = item.AverageScore;
                dgvStudent.Rows[index].Cells[3].Value = item.Faculty.FacultyName;
            }
        }
        private Student AddNewItem()
        {
            Student st = new Student();
            st.StudentID = txtBoxNumber.Text;
            st.FullName = txtBoxName.Text;
            st.AverageScore = float.Parse(txtBoxAverage.Text.ToString());
            st.FacultyID = int.Parse(cBoxFaculty.SelectedValue.ToString());
            return st;
        }

        private int ValidateItem()
        {
            if (string.IsNullOrEmpty(txtBoxNumber.Text) || 
                string.IsNullOrEmpty(txtBoxName.Text) || 
                string.IsNullOrEmpty(txtBoxAverage.Text))
            {
                return -1;
            }
            if (txtBoxNumber.Text.Length < 10)
            {
                return 0;
            }
            return 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateItem()==-1)
                {
                    MessageBox.Show("Vui lòng nhập đủ thông tin!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (ValidateItem() == 0)
                {
                    MessageBox.Show("Mã sinh viên phải có 10 kí tự!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if(!StudentManageService.ValidateItem(txtBoxNumber.Text))
                {
                    MessageBox.Show("Mã sinh viên đã trùng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                StudentManageService.AddItem(AddNewItem());
                MessageBox.Show("Thêm mới dữ liệu thành công!", "Thêm dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (StudentManageService.ValidateItem(txtBoxNumber.Text))
            {
                MessageBox.Show("Không tìm thấy MSSV cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                    DialogResult dr = MessageBox.Show("Bạn có muốn xóa ?", " YES/NO", MessageBoxButtons.YesNo);
                    if (dr == DialogResult.Yes)
                    {
                    StudentManageService.DeleteItem(txtBoxNumber.Text);
                        LoadData();
                        MessageBox.Show("Xóa sinh viên thành công", "Thông báo", MessageBoxButtons.OK);
                    }
                }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void dgvStudent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var rows = this.dgvStudent.Rows[e.RowIndex];
            txtBoxNumber.Text = rows.Cells[0].Value.ToString();
            txtBoxName.Text = rows.Cells[1].Value.ToString();
            txtBoxAverage.Text = rows.Cells[2].Value.ToString();
            cBoxFaculty.Text = rows.Cells[3].Value.ToString();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateItem() == -1)
                {
                    MessageBox.Show("Vui lòng nhập đủ thông tin!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (ValidateItem() == 0)
                {
                    MessageBox.Show("Mã sinh viên phải có 10 kí tự!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (StudentManageService.ValidateItem(txtBoxNumber.Text))
                {
                    MessageBox.Show("Không tìm thấy MSSV cần sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                StudentManageService.EditItem(AddNewItem());
                MessageBox.Show("Sửa dữ liệu thành công!", "Sửa dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult dr = new DialogResult();
            dr = MessageBox.Show("Bạn có muốn thoát chương trình!", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(dr == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnFaculty_Click(object sender, EventArgs e)
        {
            frmFaculty f = new frmFaculty();
            f.ShowDialog();
            FillFacultyCombobox();
            LoadData();
        }
    }
}
