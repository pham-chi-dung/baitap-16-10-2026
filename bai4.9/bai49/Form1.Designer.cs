namespace bai49
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
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            statusStrip1 = new StatusStrip();
            lblStatusCount = new ToolStripStatusLabel();
            btnClear = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            chkFilterDate = new CheckBox();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            cboFilterStatus = new ComboBox();
            cboStatus = new ComboBox();
            cboDoctor = new ComboBox();
            dtpFilterDate = new DateTimePicker();
            dtpDate = new DateTimePicker();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtSearch = new TextBox();
            txtName = new TextBox();
            txtReason = new TextBox();
            txtPhone = new TextBox();
            txtId = new TextBox();
            menuStrip1 = new MenuStrip();
            menuExportCSV = new ToolStripMenuItem();
            dgvAppointments = new DataGridView();
            errorProvider1 = new ErrorProvider(components);
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            statusStrip1.SuspendLayout();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAppointments).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Controls.Add(dgvAppointments, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(982, 553);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(statusStrip1);
            panel1.Controls.Add(btnClear);
            panel1.Controls.Add(btnDelete);
            panel1.Controls.Add(btnUpdate);
            panel1.Controls.Add(btnAdd);
            panel1.Controls.Add(chkFilterDate);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(cboFilterStatus);
            panel1.Controls.Add(cboStatus);
            panel1.Controls.Add(cboDoctor);
            panel1.Controls.Add(dtpFilterDate);
            panel1.Controls.Add(dtpDate);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtSearch);
            panel1.Controls.Add(txtName);
            panel1.Controls.Add(txtReason);
            panel1.Controls.Add(txtPhone);
            panel1.Controls.Add(txtId);
            panel1.Controls.Add(menuStrip1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(976, 270);
            panel1.TabIndex = 0;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { lblStatusCount });
            statusStrip1.Location = new Point(0, 244);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(976, 26);
            statusStrip1.TabIndex = 26;
            statusStrip1.Text = "statusStrip1";
            // 
            // lblStatusCount
            // 
            lblStatusCount.Name = "lblStatusCount";
            lblStatusCount.Size = new Size(96, 20);
            lblStatusCount.Text = "Số lịch hẹn: 0";
            // 
            // btnClear
            // 
            btnClear.Location = new Point(415, 168);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(94, 29);
            btnClear.TabIndex = 24;
            btnClear.Text = "làm mới";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(515, 213);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 23;
            btnDelete.Text = "xoá";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(415, 213);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 22;
            btnUpdate.Text = "sửa";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(315, 213);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 21;
            btnAdd.Text = "thêm";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // chkFilterDate
            // 
            chkFilterDate.AutoSize = true;
            chkFilterDate.Location = new Point(760, 238);
            chkFilterDate.Name = "chkFilterDate";
            chkFilterDate.Size = new Size(135, 24);
            chkFilterDate.TabIndex = 20;
            chkFilterDate.Text = "bật bộ lọc ngày";
            chkFilterDate.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(657, 203);
            label10.Name = "label10";
            label10.Size = new Size(97, 20);
            label10.TabIndex = 19;
            label10.Text = "lọc trạng thái";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(657, 159);
            label9.Name = "label9";
            label9.Size = new Size(73, 20);
            label9.TabIndex = 18;
            label9.Text = "trạng thái";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(657, 114);
            label8.Name = "label8";
            label8.Size = new Size(47, 20);
            label8.TabIndex = 17;
            label8.Text = "bác sĩ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(621, 49);
            label7.Name = "label7";
            label7.Size = new Size(99, 20);
            label7.TabIndex = 16;
            label7.Text = "lọc theo ngày";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(621, 16);
            label6.Name = "label6";
            label6.Size = new Size(69, 20);
            label6.TabIndex = 15;
            label6.Text = "ngày hẹn";
            // 
            // cboFilterStatus
            // 
            cboFilterStatus.FormattingEnabled = true;
            cboFilterStatus.Location = new Point(760, 195);
            cboFilterStatus.Name = "cboFilterStatus";
            cboFilterStatus.Size = new Size(151, 28);
            cboFilterStatus.TabIndex = 14;
            // 
            // cboStatus
            // 
            cboStatus.FormattingEnabled = true;
            cboStatus.Location = new Point(760, 151);
            cboStatus.Name = "cboStatus";
            cboStatus.Size = new Size(151, 28);
            cboStatus.TabIndex = 13;
            // 
            // cboDoctor
            // 
            cboDoctor.FormattingEnabled = true;
            cboDoctor.Location = new Point(760, 106);
            cboDoctor.Name = "cboDoctor";
            cboDoctor.Size = new Size(151, 28);
            cboDoctor.TabIndex = 12;
            // 
            // dtpFilterDate
            // 
            dtpFilterDate.Location = new Point(726, 42);
            dtpFilterDate.Name = "dtpFilterDate";
            dtpFilterDate.Size = new Size(250, 27);
            dtpFilterDate.TabIndex = 11;
            // 
            // dtpDate
            // 
            dtpDate.CustomFormat = "dd/MM/yyyy HH:mm";
            dtpDate.Format = DateTimePickerFormat.Custom;
            dtpDate.Location = new Point(729, 9);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(250, 27);
            dtpDate.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(3, 139);
            label5.Name = "label5";
            label5.Size = new Size(70, 20);
            label5.TabIndex = 9;
            label5.Text = "Tìm kiếm";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 106);
            label4.Name = "label4";
            label4.Size = new Size(44, 20);
            label4.TabIndex = 8;
            label4.Text = "Lý do";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 73);
            label3.Name = "label3";
            label3.Size = new Size(36, 20);
            label3.TabIndex = 7;
            label3.Text = "SĐT";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 40);
            label2.Name = "label2";
            label2.Size = new Size(54, 20);
            label2.TabIndex = 6;
            label2.Text = "Họ tên";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 177);
            label1.Name = "label1";
            label1.Size = new Size(52, 20);
            label1.TabIndex = 5;
            label1.Text = "Mã LH";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(153, 132);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(125, 27);
            txtSearch.TabIndex = 4;
            // 
            // txtName
            // 
            txtName.Location = new Point(153, 33);
            txtName.Name = "txtName";
            txtName.Size = new Size(125, 27);
            txtName.TabIndex = 3;
            // 
            // txtReason
            // 
            txtReason.Location = new Point(153, 99);
            txtReason.Name = "txtReason";
            txtReason.Size = new Size(125, 27);
            txtReason.TabIndex = 2;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(153, 66);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(125, 27);
            txtPhone.TabIndex = 1;
            // 
            // txtId
            // 
            txtId.Location = new Point(153, 170);
            txtId.Name = "txtId";
            txtId.Size = new Size(125, 27);
            txtId.TabIndex = 0;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuExportCSV });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(976, 28);
            menuStrip1.TabIndex = 25;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuExportCSV
            // 
            menuExportCSV.Name = "menuExportCSV";
            menuExportCSV.Size = new Size(83, 24);
            menuExportCSV.Text = "Xuất CSV";
            // 
            // dgvAppointments
            // 
            dgvAppointments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAppointments.Dock = DockStyle.Fill;
            dgvAppointments.Location = new Point(3, 279);
            dgvAppointments.Name = "dgvAppointments";
            dgvAppointments.RowHeadersWidth = 51;
            dgvAppointments.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAppointments.Size = new Size(976, 271);
            dgvAppointments.TabIndex = 1;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 553);
            Controls.Add(tableLayoutPanel1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAppointments).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtSearch;
        private TextBox txtName;
        private TextBox txtReason;
        private TextBox txtPhone;
        private TextBox txtId;
        private DateTimePicker dtpFilterDate;
        private DateTimePicker dtpDate;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private ComboBox cboFilterStatus;
        private ComboBox cboStatus;
        private ComboBox cboDoctor;
        private Button btnClear;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnAdd;
        private CheckBox chkFilterDate;
        private ErrorProvider errorProvider1;
        private MenuStrip menuStrip1;
        private DataGridView dgvAppointments;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel lblStatusCount;
        private ToolStripMenuItem menuExportCSV;
    }
}
