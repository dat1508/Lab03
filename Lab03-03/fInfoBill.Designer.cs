
namespace Lab03_03
{
    partial class fInfoBill
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.date2 = new System.Windows.Forms.DateTimePicker();
            this.date1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBoxAll = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvProductInfo = new System.Windows.Forms.DataGridView();
            this.clbSTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clbNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clbDateBuy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clbDateDeli = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clbTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.date2);
            this.groupBox1.Controls.Add(this.date1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.checkBoxAll);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(9, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(780, 109);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Đơn Hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(365, 69);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "~";
            // 
            // date2
            // 
            this.date2.CustomFormat = "dd/MM/yyyy";
            this.date2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date2.Location = new System.Drawing.Point(398, 67);
            this.date2.Margin = new System.Windows.Forms.Padding(2);
            this.date2.Name = "date2";
            this.date2.Size = new System.Drawing.Size(151, 24);
            this.date2.TabIndex = 3;
            this.date2.ValueChanged += new System.EventHandler(this.date1_ValueChanged);
            // 
            // date1
            // 
            this.date1.AllowDrop = true;
            this.date1.CustomFormat = "dd/MM/yyyy";
            this.date1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date1.Location = new System.Drawing.Point(199, 67);
            this.date1.Margin = new System.Windows.Forms.Padding(2);
            this.date1.Name = "date1";
            this.date1.Size = new System.Drawing.Size(151, 24);
            this.date1.TabIndex = 2;
            this.date1.Value = new System.DateTime(2020, 12, 31, 0, 0, 0, 0);
            this.date1.ValueChanged += new System.EventHandler(this.date1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 70);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Thời Gian Giao Hàng";
            // 
            // checkBoxAll
            // 
            this.checkBoxAll.AutoSize = true;
            this.checkBoxAll.Location = new System.Drawing.Point(58, 22);
            this.checkBoxAll.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxAll.Name = "checkBoxAll";
            this.checkBoxAll.Size = new System.Drawing.Size(171, 21);
            this.checkBoxAll.TabIndex = 0;
            this.checkBoxAll.Text = "Xem tất cả trong tháng";
            this.checkBoxAll.UseVisualStyleBackColor = true;
            this.checkBoxAll.CheckedChanged += new System.EventHandler(this.checkBoxAll_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvProductInfo);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(9, 114);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(780, 274);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // dgvProductInfo
            // 
            this.dgvProductInfo.AllowUserToAddRows = false;
            this.dgvProductInfo.AllowUserToDeleteRows = false;
            this.dgvProductInfo.ColumnHeadersHeight = 29;
            this.dgvProductInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvProductInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clbSTT,
            this.clbNumber,
            this.clbDateBuy,
            this.clbDateDeli,
            this.clbTotal});
            this.dgvProductInfo.Location = new System.Drawing.Point(0, 0);
            this.dgvProductInfo.Margin = new System.Windows.Forms.Padding(2);
            this.dgvProductInfo.Name = "dgvProductInfo";
            this.dgvProductInfo.ReadOnly = true;
            this.dgvProductInfo.RowHeadersWidth = 51;
            this.dgvProductInfo.RowTemplate.Height = 24;
            this.dgvProductInfo.Size = new System.Drawing.Size(780, 274);
            this.dgvProductInfo.TabIndex = 0;
            // 
            // clbSTT
            // 
            this.clbSTT.HeaderText = "STT";
            this.clbSTT.MinimumWidth = 6;
            this.clbSTT.Name = "clbSTT";
            this.clbSTT.ReadOnly = true;
            this.clbSTT.Width = 125;
            // 
            // clbNumber
            // 
            this.clbNumber.HeaderText = "Số HĐ";
            this.clbNumber.MinimumWidth = 6;
            this.clbNumber.Name = "clbNumber";
            this.clbNumber.ReadOnly = true;
            this.clbNumber.Width = 125;
            // 
            // clbDateBuy
            // 
            this.clbDateBuy.HeaderText = "Ngày Đặt Mua";
            this.clbDateBuy.MinimumWidth = 6;
            this.clbDateBuy.Name = "clbDateBuy";
            this.clbDateBuy.ReadOnly = true;
            this.clbDateBuy.Width = 125;
            // 
            // clbDateDeli
            // 
            this.clbDateDeli.HeaderText = "Ngày Giao Hàng";
            this.clbDateDeli.MinimumWidth = 6;
            this.clbDateDeli.Name = "clbDateDeli";
            this.clbDateDeli.ReadOnly = true;
            this.clbDateDeli.Width = 125;
            // 
            // clbTotal
            // 
            this.clbTotal.HeaderText = "Thành Tiền";
            this.clbTotal.MinimumWidth = 6;
            this.clbTotal.Name = "clbTotal";
            this.clbTotal.ReadOnly = true;
            this.clbTotal.Width = 125;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(506, 395);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tổng Cộng:";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(617, 392);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(173, 24);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // fInfoBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 425);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "fInfoBill";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông Tin Đơn Hàng";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker date2;
        private System.Windows.Forms.DateTimePicker date1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBoxAll;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvProductInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clbSTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn clbNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn clbDateBuy;
        private System.Windows.Forms.DataGridViewTextBoxColumn clbDateDeli;
        private System.Windows.Forms.DataGridViewTextBoxColumn clbTotal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
    }
}

