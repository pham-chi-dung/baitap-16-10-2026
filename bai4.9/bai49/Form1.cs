using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace bai49
{
    public partial class Form1 : Form
    {
        private List<Appointment> _masterList;
        private BindingList<Appointment> _displayList;
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
            _masterList = new List<Appointment>();
            _displayList = new BindingList<Appointment>(_masterList);
            _bindingSource = new BindingSource { DataSource = _displayList };
            dgvAppointments.DataSource = _bindingSource;

            // Khởi tạo dữ liệu ComboBox
            string[] statuses = { "Chờ khám", "Đang khám", "Hoàn tất", "Đã hủy" };
            cboStatus.Items.AddRange(statuses);

            cboFilterStatus.Items.Add("Tất cả");
            cboFilterStatus.Items.AddRange(statuses);
            cboFilterStatus.SelectedIndex = 0;

            string[] doctors = { "BS. Nguyễn Văn A", "BS. Trần Thị B", "BS. Lê Văn C" };
            cboDoctor.Items.AddRange(doctors);
            if (cboDoctor.Items.Count > 0) cboDoctor.SelectedIndex = 0;
            if (cboStatus.Items.Count > 0) cboStatus.SelectedIndex = 0;
        }

        private void SetupDataGridView()
        {
            dgvAppointments.Columns.Clear();
            dgvAppointments.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Id", HeaderText = "Mã LH", Width = 80 });
            dgvAppointments.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "PatientName", HeaderText = "Tên Bệnh Nhân", Width = 150 });
            dgvAppointments.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Phone", HeaderText = "Số ĐT", Width = 100 });
            dgvAppointments.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "AppointmentDate", HeaderText = "Ngày Giờ", Width = 130, DefaultCellStyle = new DataGridViewCellStyle { Format = "dd/MM/yyyy HH:mm" } });
            dgvAppointments.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Doctor", HeaderText = "Bác Sĩ", Width = 120 });
            dgvAppointments.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Status", HeaderText = "Trạng Thái", Width = 100 });
        }

        private void SetupEvents()
        {
            btnAdd.Click += BtnAdd_Click;
            btnUpdate.Click += BtnUpdate_Click;
            btnDelete.Click += BtnDelete_Click;
            btnClear.Click += BtnClear_Click;
            menuExportCSV.Click += MenuExportCSV_Click;
            dgvAppointments.SelectionChanged += DgvAppointments_SelectionChanged;

            // Bắt sự kiện lọc dữ liệu
            txtSearch.TextChanged += (s, e) => FilterData();
            cboFilterStatus.SelectedIndexChanged += (s, e) => FilterData();
            dtpFilterDate.ValueChanged += (s, e) => FilterData();
            if (this.Controls.Find("chkFilterDate", true).FirstOrDefault() is CheckBox chk)
                chk.CheckedChanged += (s, e) => FilterData();
        }

        private bool ValidateInput(bool isUpdate)
        {
            errorProvider1.Clear();
            bool isValid = true;

            if (string.IsNullOrWhiteSpace(txtId.Text))
            {
                errorProvider1.SetError(txtId, "Mã lịch hẹn không được để trống.");
                isValid = false;
            }
            else if (!isUpdate && _masterList.Any(a => a.Id.Equals(txtId.Text.Trim(), StringComparison.OrdinalIgnoreCase)))
            {
                errorProvider1.SetError(txtId, "Mã lịch hẹn đã tồn tại.");
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                errorProvider1.SetError(txtName, "Họ tên không được để trống.");
                isValid = false;
            }

            if (!Regex.IsMatch(txtPhone.Text, @"^0\d{9}$"))
            {
                errorProvider1.SetError(txtPhone, "SĐT không hợp lệ (10 số, bắt đầu bằng 0).");
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(txtReason.Text))
            {
                errorProvider1.SetError(txtReason, "Lý do khám không được để trống.");
                isValid = false;
            }

            if (!isUpdate && dtpDate.Value < DateTime.Now.AddMinutes(-1))
            {
                errorProvider1.SetError(dtpDate, "Ngày giờ hẹn không được trong quá khứ.");
                isValid = false;
            }

            return isValid;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateInput(false)) return;

            _masterList.Add(new Appointment
            {
                Id = txtId.Text.Trim(),
                PatientName = txtName.Text.Trim(),
                Phone = txtPhone.Text.Trim(),
                AppointmentDate = dtpDate.Value,
                Doctor = cboDoctor.SelectedItem?.ToString() ?? "",
                Reason = txtReason.Text.Trim(),
                Status = cboStatus.SelectedItem?.ToString() ?? "Chờ khám"
            });
            FilterData();
            BtnClear_Click(null, null);
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (!ValidateInput(true)) return;

            var appt = _masterList.FirstOrDefault(a => a.Id == txtId.Text.Trim());
            if (appt != null)
            {
                appt.PatientName = txtName.Text.Trim();
                appt.Phone = txtPhone.Text.Trim();
                appt.AppointmentDate = dtpDate.Value;
                appt.Doctor = cboDoctor.SelectedItem?.ToString() ?? "";
                appt.Reason = txtReason.Text.Trim();
                appt.Status = cboStatus.SelectedItem?.ToString() ?? "Chờ khám";

                FilterData();
                MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (dgvAppointments.CurrentRow?.DataBoundItem is Appointment appt)
            {
                if (MessageBox.Show($"Xóa lịch hẹn {appt.Id}?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    _masterList.Remove(appt);
                    FilterData();
                    BtnClear_Click(null, null);
                }
            }
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            txtId.Clear();
            txtId.ReadOnly = false;
            txtName.Clear();
            txtPhone.Clear();
            txtReason.Clear();
            dtpDate.Value = DateTime.Now;
            if (cboDoctor.Items.Count > 0) cboDoctor.SelectedIndex = 0;
            if (cboStatus.Items.Count > 0) cboStatus.SelectedIndex = 0;
            errorProvider1.Clear();
        }

        private void DgvAppointments_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvAppointments.CurrentRow?.DataBoundItem is Appointment appt)
            {
                txtId.Text = appt.Id;
                txtId.ReadOnly = true;
                txtName.Text = appt.PatientName;
                txtPhone.Text = appt.Phone;
                dtpDate.Value = appt.AppointmentDate;
                txtReason.Text = appt.Reason;
                cboDoctor.SelectedItem = appt.Doctor;
                cboStatus.SelectedItem = appt.Status;
                errorProvider1.Clear();
            }
        }

        private void FilterData()
        {
            var query = _masterList.AsQueryable();

            string keyword = txtSearch.Text.Trim().ToLower();
            if (!string.IsNullOrEmpty(keyword))
            {
                query = query.Where(a => a.PatientName.ToLower().Contains(keyword) || a.Phone.Contains(keyword));
            }

            if (cboFilterStatus.SelectedIndex > 0)
            {
                string status = cboFilterStatus.SelectedItem.ToString();
                query = query.Where(a => a.Status == status);
            }

            if (this.Controls.Find("chkFilterDate", true).FirstOrDefault() is CheckBox chk && chk.Checked)
            {
                query = query.Where(a => a.AppointmentDate.Date == dtpFilterDate.Value.Date);
            }

            _displayList.Clear();
            foreach (var item in query.ToList()) _displayList.Add(item);

            lblStatusCount.Text = $"Số lịch hẹn: {_displayList.Count}";
        }

        private void MenuExportCSV_Click(object sender, EventArgs e)
        {
            if (_displayList.Count == 0) return;

            using (SaveFileDialog sfd = new SaveFileDialog { Filter = "CSV File|*.csv", FileName = "LichHen.csv" })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    using (StreamWriter sw = new StreamWriter(sfd.FileName, false, Encoding.UTF8))
                    {
                        sw.WriteLine("Id,PatientName,Phone,AppointmentDate,Doctor,Reason,Status");
                        foreach (var appt in _displayList)
                        {
                            string name = appt.PatientName.Contains(",") ? $"\"{appt.PatientName}\"" : appt.PatientName;
                            string reason = appt.Reason.Contains(",") ? $"\"{appt.Reason}\"" : appt.Reason;
                            sw.WriteLine($"{appt.Id},{name},{appt.Phone},{appt.AppointmentDate:dd/MM/yyyy HH:mm},{appt.Doctor},{reason},{appt.Status}");
                        }
                    }
                    MessageBox.Show("Xuất file thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }

    public class Appointment
    {
        public string Id { get; set; }
        public string PatientName { get; set; }
        public string Phone { get; set; }
        public DateTime AppointmentDate { get; set; }
        public string Doctor { get; set; }
        public string Reason { get; set; }
        public string Status { get; set; }
    }
}

