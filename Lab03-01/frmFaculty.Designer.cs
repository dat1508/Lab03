
namespace Lab03_01
{
    partial class frmFaculty
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
            this.gBoxInfo = new System.Windows.Forms.GroupBox();
            this.txtBoxNumPro = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxFaculty = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvFaculty = new System.Windows.Forms.DataGridView();
            this.clbNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clbName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clbNumberPro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gBoxInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFaculty)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gBoxInfo
            // 
            this.gBoxInfo.Controls.Add(this.txtBoxNumPro);
            this.gBoxInfo.Controls.Add(this.label3);
            this.gBoxInfo.Controls.Add(this.txtBoxFaculty);
            this.gBoxInfo.Controls.Add(this.label2);
            this.gBoxInfo.Controls.Add(this.txtBoxNumber);
            this.gBoxInfo.Controls.Add(this.label1);
            this.gBoxInfo.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBoxInfo.Location = new System.Drawing.Point(9, 10);
            this.gBoxInfo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gBoxInfo.Name = "gBoxInfo";
            this.gBoxInfo.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gBoxInfo.Size = new System.Drawing.Size(286, 257);
            this.gBoxInfo.TabIndex = 0;
            this.gBoxInfo.TabStop = false;
            this.gBoxInfo.Text = "Thông Tin Khoa";
            // 
            // txtBoxNumPro
            // 
            this.txtBoxNumPro.Location = new System.Drawing.Point(93, 135);
            this.txtBoxNumPro.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBoxNumPro.Name = "txtBoxNumPro";
            this.txtBoxNumPro.Size = new System.Drawing.Size(118, 24);
            this.txtBoxNumPro.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 137);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tổng số GS";
            // 
            // txtBoxFaculty
            // 
            this.txtBoxFaculty.Location = new System.Drawing.Point(93, 89);
            this.txtBoxFaculty.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBoxFaculty.Name = "txtBoxFaculty";
            this.txtBoxFaculty.Size = new System.Drawing.Size(190, 24);
            this.txtBoxFaculty.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 92);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên Khoa";
            // 
            // txtBoxNumber
            // 
            this.txtBoxNumber.Location = new System.Drawing.Point(93, 50);
            this.txtBoxNumber.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBoxNumber.Name = "txtBoxNumber";
            this.txtBoxNumber.Size = new System.Drawing.Size(118, 24);
            this.txtBoxNumber.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 50);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Khoa";
            // 
            // dgvFaculty
            // 
            this.dgvFaculty.AllowUserToAddRows = false;
            this.dgvFaculty.AllowUserToDeleteRows = false;
            this.dgvFaculty.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFaculty.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clbNumber,
            this.clbName,
            this.clbNumberPro});
            this.dgvFaculty.Location = new System.Drawing.Point(0, 5);
            this.dgvFaculty.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvFaculty.Name = "dgvFaculty";
            this.dgvFaculty.ReadOnly = true;
            this.dgvFaculty.RowHeadersWidth = 51;
            this.dgvFaculty.RowTemplate.Height = 24;
            this.dgvFaculty.Size = new System.Drawing.Size(406, 301);
            this.dgvFaculty.TabIndex = 1;
            this.dgvFaculty.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFaculty_CellClick);
            // 
            // clbNumber
            // 
            this.clbNumber.HeaderText = "Mã Khoa";
            this.clbNumber.MinimumWidth = 6;
            this.clbNumber.Name = "clbNumber";
            this.clbNumber.ReadOnly = true;
            this.clbNumber.Width = 125;
            // 
            // clbName
            // 
            this.clbName.HeaderText = "Tên Khoa";
            this.clbName.MinimumWidth = 6;
            this.clbName.Name = "clbName";
            this.clbName.ReadOnly = true;
            this.clbName.Width = 125;
            // 
            // clbNumberPro
            // 
            this.clbNumberPro.HeaderText = "Tổng số GS";
            this.clbNumberPro.MinimumWidth = 6;
            this.clbNumberPro.Name = "clbNumberPro";
            this.clbNumberPro.ReadOnly = true;
            this.clbNumberPro.Width = 125;
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(620, 320);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(87, 28);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(60, 287);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(144, 28);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Thêm / Sửa";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(208, 287);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(87, 28);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvFaculty);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(300, 10);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(406, 306);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            // 
            // frmFaculty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 358);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.gBoxInfo);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmFaculty";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Khoa";
            this.gBoxInfo.ResumeLayout(false);
            this.gBoxInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFaculty)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gBoxInfo;
        private System.Windows.Forms.TextBox txtBoxNumPro;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBoxFaculty;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvFaculty;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn clbNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn clbName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clbNumberPro;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}