namespace bai410
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            txtReceiptId = new TextBox();
            txtStudentId = new TextBox();
            txtStudentName = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            numQuantity = new NumericUpDown();
            cboEquipment = new ComboBox();
            cboStatus = new ComboBox();
            label4 = new Label();
            label5 = new Label();
            dtpBorrowDate = new DateTimePicker();
            dtpDueDate = new DateTimePicker();
            dtpReturnDate = new DateTimePicker();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            panel2 = new Panel();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnClear = new Button();
            txtSearch = new TextBox();
            label9 = new Label();
            cboFilterStatus = new ComboBox();
            label10 = new Label();
            btnExport = new Button();
            errorProvider1 = new ErrorProvider(components);
            dgvCheckouts = new DataGridView();
            statusStrip1 = new StatusStrip();
            lblStatus = new ToolStripStatusLabel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numQuantity).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCheckouts).BeginInit();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnClear);
            panel1.Controls.Add(btnDelete);
            panel1.Controls.Add(btnUpdate);
            panel1.Controls.Add(btnAdd);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(dtpReturnDate);
            panel1.Controls.Add(dtpDueDate);
            panel1.Controls.Add(dtpBorrowDate);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(cboStatus);
            panel1.Controls.Add(cboEquipment);
            panel1.Controls.Add(numQuantity);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtStudentName);
            panel1.Controls.Add(txtStudentId);
            panel1.Controls.Add(txtReceiptId);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1138, 250);
            panel1.TabIndex = 0;
            // 
            // txtReceiptId
            // 
            txtReceiptId.Location = new Point(80, 9);
            txtReceiptId.Name = "txtReceiptId";
            txtReceiptId.Size = new Size(125, 27);
            txtReceiptId.TabIndex = 0;
            // 
            // txtStudentId
            // 
            txtStudentId.Location = new Point(80, 44);
            txtStudentId.Name = "txtStudentId";
            txtStudentId.Size = new Size(125, 27);
            txtStudentId.TabIndex = 1;
            // 
            // txtStudentName
            // 
            txtStudentName.Location = new Point(80, 80);
            txtStudentName.Name = "txtStudentName";
            txtStudentName.Size = new Size(125, 27);
            txtStudentName.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 9);
            label1.Name = "label1";
            label1.Size = new Size(71, 20);
            label1.TabIndex = 3;
            label1.Text = "mã phiếu";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 44);
            label2.Name = "label2";
            label2.Size = new Size(51, 20);
            label2.TabIndex = 4;
            label2.Text = "mã SV";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 76);
            label3.Name = "label3";
            label3.Size = new Size(51, 20);
            label3.TabIndex = 5;
            label3.Text = "họ tên";
            // 
            // numQuantity
            // 
            numQuantity.Location = new Point(875, 80);
            numQuantity.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numQuantity.Name = "numQuantity";
            numQuantity.Size = new Size(150, 27);
            numQuantity.TabIndex = 6;
            numQuantity.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // cboEquipment
            // 
            cboEquipment.FormattingEnabled = true;
            cboEquipment.Location = new Point(552, 37);
            cboEquipment.Name = "cboEquipment";
            cboEquipment.Size = new Size(151, 28);
            cboEquipment.TabIndex = 7;
            // 
            // cboStatus
            // 
            cboStatus.FormattingEnabled = true;
            cboStatus.Location = new Point(561, 102);
            cboStatus.Name = "cboStatus";
            cboStatus.Size = new Size(151, 28);
            cboStatus.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(457, 42);
            label4.Name = "label4";
            label4.Size = new Size(56, 20);
            label4.TabIndex = 9;
            label4.Text = "thiết bị";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(473, 102);
            label5.Name = "label5";
            label5.Size = new Size(73, 20);
            label5.TabIndex = 10;
            label5.Text = "tình trạng";
            // 
            // dtpBorrowDate
            // 
            dtpBorrowDate.CustomFormat = "dd/MM/yyyy";
            dtpBorrowDate.Format = DateTimePickerFormat.Custom;
            dtpBorrowDate.Location = new Point(854, 131);
            dtpBorrowDate.Name = "dtpBorrowDate";
            dtpBorrowDate.Size = new Size(250, 27);
            dtpBorrowDate.TabIndex = 11;
            // 
            // dtpDueDate
            // 
            dtpDueDate.CustomFormat = "dd/MM/yyyy";
            dtpDueDate.Format = DateTimePickerFormat.Custom;
            dtpDueDate.Location = new Point(854, 164);
            dtpDueDate.Name = "dtpDueDate";
            dtpDueDate.Size = new Size(250, 27);
            dtpDueDate.TabIndex = 12;
            // 
            // dtpReturnDate
            // 
            dtpReturnDate.CustomFormat = "dd/MM/yyyy";
            dtpReturnDate.Enabled = false;
            dtpReturnDate.Format = DateTimePickerFormat.Custom;
            dtpReturnDate.Location = new Point(854, 197);
            dtpReturnDate.Name = "dtpReturnDate";
            dtpReturnDate.Size = new Size(250, 27);
            dtpReturnDate.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(741, 136);
            label6.Name = "label6";
            label6.Size = new Size(84, 20);
            label6.TabIndex = 14;
            label6.Text = "ngày mượn";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(751, 169);
            label7.Name = "label7";
            label7.Size = new Size(55, 20);
            label7.TabIndex = 15;
            label7.Text = "hạn trả";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(741, 204);
            label8.Name = "label8";
            label8.Size = new Size(105, 20);
            label8.TabIndex = 16;
            label8.Text = "hạn trả thực tế";
            // 
            // panel2
            // 
            panel2.Controls.Add(btnExport);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(cboFilterStatus);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(txtSearch);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 250);
            panel2.Name = "panel2";
            panel2.Size = new Size(1138, 50);
            panel2.TabIndex = 1;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(351, 123);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 17;
            btnAdd.Text = "thêm";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(351, 165);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 18;
            btnUpdate.Text = "cập nhật";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(351, 204);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 19;
            btnDelete.Text = "xoá";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(457, 204);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(94, 29);
            btnClear.TabIndex = 20;
            btnClear.Text = "làm mới";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(126, 13);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(125, 27);
            txtSearch.TabIndex = 0;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(3, 16);
            label9.Name = "label9";
            label9.Size = new Size(126, 20);
            label9.TabIndex = 1;
            label9.Text = "tìm mã sv/thiết bị";
            // 
            // cboFilterStatus
            // 
            cboFilterStatus.FormattingEnabled = true;
            cboFilterStatus.Location = new Point(508, 12);
            cboFilterStatus.Name = "cboFilterStatus";
            cboFilterStatus.Size = new Size(151, 28);
            cboFilterStatus.TabIndex = 2;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(405, 16);
            label10.Name = "label10";
            label10.Size = new Size(97, 20);
            label10.TabIndex = 3;
            label10.Text = "lọc tình trạng";
            // 
            // btnExport
            // 
            btnExport.Location = new Point(958, 13);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(94, 29);
            btnExport.TabIndex = 4;
            btnExport.Text = "xuất CSV";
            btnExport.UseVisualStyleBackColor = true;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // dgvCheckouts
            // 
            dgvCheckouts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCheckouts.Dock = DockStyle.Fill;
            dgvCheckouts.Location = new Point(0, 300);
            dgvCheckouts.Name = "dgvCheckouts";
            dgvCheckouts.RowHeadersWidth = 51;
            dgvCheckouts.Size = new Size(1138, 261);
            dgvCheckouts.TabIndex = 2;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { lblStatus });
            statusStrip1.Location = new Point(0, 535);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1138, 26);
            statusStrip1.TabIndex = 3;
            statusStrip1.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(151, 20);
            lblStatus.Text = "toolStripStatusLabel1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1138, 561);
            Controls.Add(statusStrip1);
            Controls.Add(dgvCheckouts);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numQuantity).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCheckouts).EndInit();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtStudentName;
        private TextBox txtStudentId;
        private TextBox txtReceiptId;
        private Label label5;
        private Label label4;
        private ComboBox cboStatus;
        private ComboBox cboEquipment;
        private NumericUpDown numQuantity;
        private Label label8;
        private Label label7;
        private Label label6;
        private DateTimePicker dtpReturnDate;
        private DateTimePicker dtpDueDate;
        private DateTimePicker dtpBorrowDate;
        private Panel panel2;
        private Button btnClear;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnAdd;
        private Label label9;
        private TextBox txtSearch;
        private Button btnExport;
        private Label label10;
        private ComboBox cboFilterStatus;
        private ErrorProvider errorProvider1;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel lblStatus;
        private DataGridView dgvCheckouts;
    }
}
