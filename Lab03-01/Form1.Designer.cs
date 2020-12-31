
namespace Lab02_02
{
    partial class fQuanLySinhVien
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
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBoxNumber = new System.Windows.Forms.TextBox();
            this.txtBoxName = new System.Windows.Forms.TextBox();
            this.txtBoxAverage = new System.Windows.Forms.TextBox();
            this.cBoxFaculty = new System.Windows.Forms.ComboBox();
            this.gBoxStudent = new System.Windows.Forms.GroupBox();
            this.gBoxData = new System.Windows.Forms.GroupBox();
            this.dgvStudent = new System.Windows.Forms.DataGridView();
            this.Clbnumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClbName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClbAverage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClbFaculty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAdd = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnFaculty = new System.Windows.Forms.Button();
            this.gBoxStudent.SuspendLayout();
            this.gBoxData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(353, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(404, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản Lý Thông Tin Sinh Viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã Sinh Viên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "Họ Tên";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 21);
            this.label5.TabIndex = 4;
            this.label5.Text = "Điểm TB";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 245);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 21);
            this.label6.TabIndex = 5;
            this.label6.Text = "Chuyên Ngành";
            // 
            // txtBoxNumber
            // 
            this.txtBoxNumber.Location = new System.Drawing.Point(179, 50);
            this.txtBoxNumber.Name = "txtBoxNumber";
            this.txtBoxNumber.Size = new System.Drawing.Size(169, 28);
            this.txtBoxNumber.TabIndex = 1;
            // 
            // txtBoxName
            // 
            this.txtBoxName.Location = new System.Drawing.Point(179, 111);
            this.txtBoxName.Name = "txtBoxName";
            this.txtBoxName.Size = new System.Drawing.Size(299, 28);
            this.txtBoxName.TabIndex = 2;
            // 
            // txtBoxAverage
            // 
            this.txtBoxAverage.Location = new System.Drawing.Point(179, 175);
            this.txtBoxAverage.Name = "txtBoxAverage";
            this.txtBoxAverage.Size = new System.Drawing.Size(100, 28);
            this.txtBoxAverage.TabIndex = 3;
            // 
            // cBoxFaculty
            // 
            this.cBoxFaculty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxFaculty.FormattingEnabled = true;
            this.cBoxFaculty.Location = new System.Drawing.Point(179, 237);
            this.cBoxFaculty.Name = "cBoxFaculty";
            this.cBoxFaculty.Size = new System.Drawing.Size(283, 29);
            this.cBoxFaculty.TabIndex = 4;
            // 
            // gBoxStudent
            // 
            this.gBoxStudent.Controls.Add(this.label2);
            this.gBoxStudent.Controls.Add(this.label3);
            this.gBoxStudent.Controls.Add(this.txtBoxAverage);
            this.gBoxStudent.Controls.Add(this.label6);
            this.gBoxStudent.Controls.Add(this.cBoxFaculty);
            this.gBoxStudent.Controls.Add(this.txtBoxName);
            this.gBoxStudent.Controls.Add(this.label5);
            this.gBoxStudent.Controls.Add(this.txtBoxNumber);
            this.gBoxStudent.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBoxStudent.Location = new System.Drawing.Point(0, 82);
            this.gBoxStudent.Name = "gBoxStudent";
            this.gBoxStudent.Size = new System.Drawing.Size(504, 326);
            this.gBoxStudent.TabIndex = 1;
            this.gBoxStudent.TabStop = false;
            this.gBoxStudent.Text = "Thông Tin Sinh Viên";
            // 
            // gBoxData
            // 
            this.gBoxData.Controls.Add(this.dgvStudent);
            this.gBoxData.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBoxData.Location = new System.Drawing.Point(510, 84);
            this.gBoxData.Name = "gBoxData";
            this.gBoxData.Size = new System.Drawing.Size(678, 363);
            this.gBoxData.TabIndex = 14;
            this.gBoxData.TabStop = false;
            this.gBoxData.Text = "Hiển thị";
            // 
            // dgvStudent
            // 
            this.dgvStudent.AllowUserToAddRows = false;
            this.dgvStudent.AllowUserToDeleteRows = false;
            this.dgvStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Clbnumber,
            this.ClbName,
            this.ClbAverage,
            this.ClbFaculty});
            this.dgvStudent.Location = new System.Drawing.Point(0, 15);
            this.dgvStudent.Name = "dgvStudent";
            this.dgvStudent.ReadOnly = true;
            this.dgvStudent.RowHeadersWidth = 51;
            this.dgvStudent.RowTemplate.Height = 24;
            this.dgvStudent.Size = new System.Drawing.Size(678, 348);
            this.dgvStudent.TabIndex = 0;
            this.dgvStudent.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStudent_CellClick);
            // 
            // Clbnumber
            // 
            this.Clbnumber.HeaderText = "MSSV";
            this.Clbnumber.MinimumWidth = 6;
            this.Clbnumber.Name = "Clbnumber";
            this.Clbnumber.ReadOnly = true;
            this.Clbnumber.Width = 125;
            // 
            // ClbName
            // 
            this.ClbName.HeaderText = "Họ Tên";
            this.ClbName.MinimumWidth = 6;
            this.ClbName.Name = "ClbName";
            this.ClbName.ReadOnly = true;
            this.ClbName.Width = 125;
            // 
            // ClbAverage
            // 
            this.ClbAverage.HeaderText = "ĐTB";
            this.ClbAverage.MinimumWidth = 6;
            this.ClbAverage.Name = "ClbAverage";
            this.ClbAverage.ReadOnly = true;
            this.ClbAverage.Width = 125;
            // 
            // ClbFaculty
            // 
            this.ClbFaculty.HeaderText = "Khoa";
            this.ClbFaculty.MinimumWidth = 6;
            this.ClbFaculty.Name = "ClbFaculty";
            this.ClbFaculty.ReadOnly = true;
            this.ClbFaculty.Width = 125;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(183, 410);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(103, 37);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(401, 410);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(103, 37);
            this.button2.TabIndex = 7;
            this.button2.Text = "Xóa";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(292, 410);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(103, 37);
            this.btnEdit.TabIndex = 6;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(1049, 453);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(139, 37);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnFaculty
            // 
            this.btnFaculty.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFaculty.Location = new System.Drawing.Point(879, 453);
            this.btnFaculty.Name = "btnFaculty";
            this.btnFaculty.Size = new System.Drawing.Size(164, 37);
            this.btnFaculty.TabIndex = 8;
            this.btnFaculty.Text = "Quản lý Khoa";
            this.btnFaculty.UseVisualStyleBackColor = true;
            this.btnFaculty.Click += new System.EventHandler(this.btnFaculty_Click);
            // 
            // fQuanLySinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1201, 495);
            this.Controls.Add(this.btnFaculty);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.gBoxData);
            this.Controls.Add(this.gBoxStudent);
            this.Controls.Add(this.label1);
            this.Name = "fQuanLySinhVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Thông Tin Sinh Viên";
            this.gBoxStudent.ResumeLayout(false);
            this.gBoxStudent.PerformLayout();
            this.gBoxData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBoxNumber;
        private System.Windows.Forms.TextBox txtBoxName;
        private System.Windows.Forms.TextBox txtBoxAverage;
        private System.Windows.Forms.ComboBox cBoxFaculty;
        private System.Windows.Forms.GroupBox gBoxStudent;
        private System.Windows.Forms.GroupBox gBoxData;
        private System.Windows.Forms.DataGridView dgvStudent;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Clbnumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClbName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClbAverage;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClbFaculty;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnFaculty;
    }
}

