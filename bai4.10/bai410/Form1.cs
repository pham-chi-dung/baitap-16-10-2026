using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace bai410
{
    public partial class Form1 : Form
    {
        private List<CheckoutRecord> _masterList;
        private BindingList<CheckoutRecord> _displayList;
        private BindingSource _bindingSource;

        public Form1()
        {
            InitializeComponent();
            InitializeData();
            SetupDataGridView();
            SetupEvents();
        }

        private void InitializeData()
        {
            _masterList = new List<CheckoutRecord>();
            _displayList = new BindingList<CheckoutRecord>(_masterList);
            _bindingSource = new BindingSource { DataSource = _displayList };
            dgvCheckouts.DataSource = _bindingSource;

            // Khởi tạo ComboBox lọc
            cboFilterStatus.Items.AddRange(new string[] { "Tất cả", "Đang mượn", "Đã trả", "Quá hạn" });
            cboFilterStatus.SelectedIndex = 0;

            if (cboEquipment.Items.Count == 0)
                cboEquipment.Items.AddRange(new string[] { "Oscilloscope", "Đồng hồ vạn năng", "Mỏ hàn xung", "Arduino Uno" });
            if (cboStatus.Items.Count == 0)
                cboStatus.Items.AddRange(new string[] { "Đang mượn", "Đã trả", "Quá hạn" });

            cboStatus.SelectedIndex = 0;
        }

        private void SetupDataGridView()
        {
            dgvCheckouts.AutoGenerateColumns = false; // Tắt tự động tạo cột[cite: 9]
            dgvCheckouts.Columns.Clear();
            dgvCheckouts.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "ReceiptId", HeaderText = "Mã Phiếu", Width = 80 });
            dgvCheckouts.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "StudentId", HeaderText = "Mã SV", Width = 90 });
            dgvCheckouts.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "StudentName", HeaderText = "Họ Tên", Width = 140 });
            dgvCheckouts.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Equipment", HeaderText = "Thiết Bị", Width = 120 });
            dgvCheckouts.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Quantity", HeaderText = "SL", Width = 50 });
            dgvCheckouts.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "BorrowDate", HeaderText = "Ngày Mượn", Width = 100, DefaultCellStyle = new DataGridViewCellStyle { Format = "dd/MM/yyyy" } });
            dgvCheckouts.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "DueDate", HeaderText = "Hạn Trả", Width = 100, DefaultCellStyle = new DataGridViewCellStyle { Format = "dd/MM/yyyy" } });
            dgvCheckouts.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "ReturnDateDisplay", HeaderText = "Ngày Trả", Width = 100 });
            dgvCheckouts.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Status", HeaderText = "Tình Trạng", Width = 100 });
        }

        private void SetupEvents()
        {
            btnAdd.Click += BtnAdd_Click;
            btnUpdate.Click += BtnUpdate_Click;
            btnDelete.Click += BtnDelete_Click;
            btnClear.Click += BtnClear_Click;
            btnExport.Click += BtnExport_Click;

            dgvCheckouts.SelectionChanged += DgvCheckouts_SelectionChanged;
            txtSearch.TextChanged += (s, e) => FilterData();
            cboFilterStatus.SelectedIndexChanged += (s, e) => FilterData();

            // Logic: Chọn "Đã trả" thì bật chọn Ngày trả thực tế[cite: 9]
            cboStatus.SelectedIndexChanged += (s, e) =>
            {
                bool isReturned = cboStatus.SelectedItem?.ToString() == "Đã trả";
                dtpReturnDate.Enabled = isReturned;
                if (isReturned && dtpReturnDate.Value.Date < dtpBorrowDate.Value.Date)
                {
                    dtpReturnDate.Value = DateTime.Now;
                }
            };
        }

        private void AutoUpdateOverdueStatus()
        {
            // Tự động xác định phiếu quá hạn nếu hạn trả trước ngày hiện tại và chưa trả[cite: 9]
            DateTime today = DateTime.Today;
            foreach (var item in _masterList)
            {
                if (item.Status == "Đang mượn" && item.DueDate.Date < today)
                {
                    item.Status = "Quá hạn";
                }
            }
        }

        private bool ValidateInput(bool isUpdate)
        {
            errorProvider1.Clear();
            bool isValid = true;

            if (string.IsNullOrWhiteSpace(txtReceiptId.Text)) { errorProvider1.SetError(txtReceiptId, "Mã phiếu không để trống."); isValid = false; }
            else if (!isUpdate && _masterList.Any(x => x.ReceiptId.Equals(txtReceiptId.Text.Trim(), StringComparison.OrdinalIgnoreCase)))
            { errorProvider1.SetError(txtReceiptId, "Mã phiếu đã tồn tại."); isValid = false; } // Mã không trùng[cite: 9]

            if (string.IsNullOrWhiteSpace(txtStudentId.Text)) { errorProvider1.SetError(txtStudentId, "Mã SV không để trống."); isValid = false; } // Mã SV không để trống[cite: 9]
            if (string.IsNullOrWhiteSpace(cboEquipment.Text)) { errorProvider1.SetError(cboEquipment, "Thiết bị không để trống."); isValid = false; } // Thiết bị không để trống[cite: 9]
            if (numQuantity.Value <= 0) { errorProvider1.SetError(numQuantity, "Số lượng phải > 0."); isValid = false; } // SL lớn hơn 0[cite: 9]

            if (dtpDueDate.Value.Date < dtpBorrowDate.Value.Date) { errorProvider1.SetError(dtpDueDate, "Hạn trả không trước ngày mượn."); isValid = false; } // Hạn trả không trước ngày mượn[cite: 9]

            if (cboStatus.SelectedItem?.ToString() == "Đã trả" && dtpReturnDate.Value.Date < dtpBorrowDate.Value.Date)
            {
                errorProvider1.SetError(dtpReturnDate, "Ngày trả không trước ngày mượn."); // Ngày trả không trước ngày mượn[cite: 9]
                isValid = false;
            }

            return isValid;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateInput(false)) return;

            var record = new CheckoutRecord
            {
                ReceiptId = txtReceiptId.Text.Trim(),
                StudentId = txtStudentId.Text.Trim(),
                StudentName = txtStudentName.Text.Trim(),
                Equipment = cboEquipment.Text,
                Quantity = (int)numQuantity.Value,
                BorrowDate = dtpBorrowDate.Value.Date,
                DueDate = dtpDueDate.Value.Date,
                Status = cboStatus.SelectedItem?.ToString() ?? "Đang mượn"
            };

            if (record.Status == "Đã trả") record.ReturnDate = dtpReturnDate.Value.Date;
            else record.ReturnDate = null;

            _masterList.Add(record);
            FilterData();
            BtnClear_Click(null, null);
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (!ValidateInput(true)) return;

            var record = _masterList.FirstOrDefault(x => x.ReceiptId == txtReceiptId.Text.Trim());
            if (record != null)
            {
                record.StudentId = txtStudentId.Text.Trim();
                record.StudentName = txtStudentName.Text.Trim();
                record.Equipment = cboEquipment.Text;
                record.Quantity = (int)numQuantity.Value;
                record.BorrowDate = dtpBorrowDate.Value.Date;
                record.DueDate = dtpDueDate.Value.Date;
                record.Status = cboStatus.SelectedItem?.ToString() ?? "Đang mượn";

                if (record.Status == "Đã trả") record.ReturnDate = dtpReturnDate.Value.Date;
                else record.ReturnDate = null;

                FilterData();
                MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (dgvCheckouts.CurrentRow?.DataBoundItem is CheckoutRecord record)
            {
                if (MessageBox.Show($"Xóa phiếu {record.ReceiptId}?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes) // Xóa có xác nhận[cite: 9]
                {
                    _masterList.Remove(record);
                    FilterData();
                    BtnClear_Click(null, null);
                }
            }
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            txtReceiptId.Clear();
            txtReceiptId.ReadOnly = false;
            txtStudentId.Clear();
            txtStudentName.Clear();
            numQuantity.Value = 1;
            dtpBorrowDate.Value = DateTime.Now;
            dtpDueDate.Value = DateTime.Now.AddDays(7);
            cboStatus.SelectedIndex = 0;
            errorProvider1.Clear();
        }

        private void DgvCheckouts_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvCheckouts.CurrentRow?.DataBoundItem is CheckoutRecord record)
            {
                txtReceiptId.Text = record.ReceiptId;
                txtReceiptId.ReadOnly = true;
                txtStudentId.Text = record.StudentId;
                txtStudentName.Text = record.StudentName;
                cboEquipment.Text = record.Equipment;
                numQuantity.Value = record.Quantity;
                dtpBorrowDate.Value = record.BorrowDate;
                dtpDueDate.Value = record.DueDate;
                cboStatus.SelectedItem = record.Status;

                if (record.ReturnDate.HasValue)
                {
                    dtpReturnDate.Value = record.ReturnDate.Value;
                    dtpReturnDate.Enabled = true;
                }
                else
                {
                    dtpReturnDate.Value = DateTime.Now;
                    dtpReturnDate.Enabled = false;
                }
                errorProvider1.Clear();
            }
        }

        private void FilterData()
        {
            AutoUpdateOverdueStatus();

            var query = _masterList.AsQueryable();

            string keyword = txtSearch.Text.Trim().ToLower();
            if (!string.IsNullOrEmpty(keyword))
            {
                query = query.Where(x => x.StudentId.ToLower().Contains(keyword) || x.Equipment.ToLower().Contains(keyword)); // Tìm theo mã SV hoặc tên thiết bị[cite: 9]
            }

            if (cboFilterStatus.SelectedIndex > 0)
            {
                string status = cboFilterStatus.SelectedItem.ToString();
                query = query.Where(x => x.Status == status); // Lọc phiếu[cite: 9]
            }

            _displayList.Clear();
            int totalOverdue = 0;
            foreach (var item in query.ToList())
            {
                _displayList.Add(item);
                if (item.Status == "Quá hạn") totalOverdue++;
            }

            // StatusStrip hiển thị tổng số phiếu và số phiếu quá hạn[cite: 9]
            lblStatus.Text = $"Tổng số phiếu (đang hiển thị): {_displayList.Count} | Số phiếu quá hạn: {totalOverdue}";
            dgvCheckouts.Refresh();
        }

        private void BtnExport_Click(object sender, EventArgs e)
        {
            if (_displayList.Count == 0) return;

            using (SaveFileDialog sfd = new SaveFileDialog { Filter = "CSV File|*.csv", FileName = "PhieuMuon.csv" }) // Xuất CSV bằng SaveFileDialog[cite: 9]
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (StreamWriter sw = new StreamWriter(sfd.FileName, false, Encoding.UTF8))
                        {
                            sw.WriteLine("MaPhieu,MaSV,HoTen,ThietBi,SoLuong,NgayMuon,HanTra,NgayTraThucTe,TinhTrang");
                            foreach (var r in _displayList)
                            {
                                string returnDateStr = r.ReturnDate.HasValue ? r.ReturnDate.Value.ToString("dd/MM/yyyy") : "";
                                sw.WriteLine($"{r.ReceiptId},{r.StudentId},{r.StudentName},{r.Equipment},{r.Quantity},{r.BorrowDate:dd/MM/yyyy},{r.DueDate:dd/MM/yyyy},{returnDateStr},{r.Status}");
                            }
                        }
                        MessageBox.Show("Xuất file thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi xuất file: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }

    public class CheckoutRecord
    {
        public string ReceiptId { get; set; } = string.Empty;
        public string StudentId { get; set; } = string.Empty;
        public string StudentName { get; set; } = string.Empty;
        public string Equipment { get; set; } = string.Empty;
        public int Quantity { get; set; }
        public DateTime BorrowDate { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime? ReturnDate { get; set; }
        public string Status { get; set; } = string.Empty;

        // Thuộc tính phụ để hiển thị ngày trả lên DataGridView (tránh in lỗi khi null)
        public string ReturnDateDisplay => ReturnDate.HasValue ? ReturnDate.Value.ToString("dd/MM/yyyy") : "-";
    }
}