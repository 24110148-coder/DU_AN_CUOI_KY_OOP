using DU_AN_CUOI_KI_OOP.Data;
using DU_AN_CUOI_KI_OOP.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace DU_AN_CUOI_KI_OOP.user_control
{
    public partial class UC_SearchAppointment : UserControl
    {
        private readonly AppointmentRepository repo = new AppointmentRepository();

        public UC_SearchAppointment()
        {
            InitializeComponent();
            this.Load += UC_SearchAppointment_Load;
            this.btnSeacrhAppointment.Click += BtnSeacrhAppointment_Click;
            dtpStart.Format = DateTimePickerFormat.Custom;
            dtpStart.CustomFormat = "HH:mm";
            dtpStart.ShowUpDown = true;

            dtpEnd.Format = DateTimePickerFormat.Custom;
            dtpEnd.CustomFormat = "HH:mm";
            dtpEnd.ShowUpDown = true;
            // Gắn sự kiện double click cho DataGridView
            this.guna2DataGridView1.CellDoubleClick += Guna2DataGridView1_CellDoubleClick;
            this.VisibleChanged += UC_SearchAppointment_VisibleChanged;

        }
        private void UC_SearchAppointment_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible)
            {
                LoadAppointments(); // tự động refresh khi quay lại tab/UC này
            }
        }
        private void UC_SearchAppointment_Load(object sender, EventArgs e)
        {
            try
            {
                LoadAppointments();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể tải dữ liệu lịch hẹn: " + ex.Message,
                                "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadAppointments()
        {
            guna2DataGridView1.AutoGenerateColumns = false;
            SetupColumns();
            guna2DataGridView1.DataSource = repo.GetBindingList();
        }

        private void SetupColumns()
        {
            guna2DataGridView1.Columns.Clear();

            // === Cấu hình mặc định chung ===
            guna2DataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            guna2DataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            guna2DataGridView1.DefaultCellStyle.Font = new Font("Segoe UI", 9);
            guna2DataGridView1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            guna2DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            guna2DataGridView1.AllowUserToResizeColumns = false;

            // === Các cột thông tin ===
            guna2DataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Id",
                HeaderText = "ID",
                Width = 30,
                DefaultCellStyle = new DataGridViewCellStyle { Alignment = DataGridViewContentAlignment.MiddleCenter }
            });

            guna2DataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "DoctorName",
                HeaderText = "Doctor Name",
                Width = 110
            });

            guna2DataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "DoctorId",
                HeaderText = "Doctor ID",
                Width = 80,
                DefaultCellStyle = new DataGridViewCellStyle { Alignment = DataGridViewContentAlignment.MiddleCenter }
            });

            guna2DataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Specialty",
                HeaderText = "Specialty",
                Width = 100
            });

            guna2DataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "PatientName",
                HeaderText = "Patient Name",
                Width = 110
            });

            guna2DataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "PatientId",
                HeaderText = "Patient ID",
                Width = 80,
                DefaultCellStyle = new DataGridViewCellStyle { Alignment = DataGridViewContentAlignment.MiddleCenter }
            });

            guna2DataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Age",
                HeaderText = "Age",
                Width = 40,
                DefaultCellStyle = new DataGridViewCellStyle { Alignment = DataGridViewContentAlignment.MiddleCenter }
            });

            guna2DataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "PatientType",
                HeaderText = "Type",
                Width = 50,
                DefaultCellStyle = new DataGridViewCellStyle { Alignment = DataGridViewContentAlignment.MiddleCenter }
            });

            // === Cột thời gian ===
            guna2DataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "StartTime",
                HeaderText = "Start",
                Width = 80,
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Format = "HH:mm",
                    Alignment = DataGridViewContentAlignment.MiddleCenter
                }
            });

            guna2DataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "EndTime",
                HeaderText = "End",
                Width = 80,
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Format = "HH:mm",
                    Alignment = DataGridViewContentAlignment.MiddleCenter
                }
            });

            guna2DataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Date",
                HeaderText = "Date",
                Width = 100,
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Format = "dd/MM/yyyy",
                    Alignment = DataGridViewContentAlignment.MiddleCenter
                }
            });

            guna2DataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Notes",
                HeaderText = "Notes",
                Width = 200,
                DefaultCellStyle = new DataGridViewCellStyle { WrapMode = DataGridViewTriState.True }
            });
            guna2DataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            guna2DataGridView1.ColumnHeadersHeight = 35;
            guna2DataGridView1.RowTemplate.Height = 30;
            guna2DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }



        private void BtnSeacrhAppointment_Click(object sender, EventArgs e)
        {
            try
            {
                var results = repo.GetAllAppointments().ToList();

                if (!string.IsNullOrWhiteSpace(txtNameDoctor.Text))
                    results = results.Where(a => a.Doctor.Name.Contains(txtNameDoctor.Text.Trim())).ToList();

                if (!string.IsNullOrWhiteSpace(txtIDDT.Text) && int.TryParse(txtIDDT.Text, out int doctorId))
                    results = results.Where(a => a.Doctor.Id == doctorId).ToList();

                if (!string.IsNullOrWhiteSpace(txtNamePatient.Text))
                    results = results.Where(a => a.Patient.Name.Contains(txtNamePatient.Text.Trim())).ToList();

                if (!string.IsNullOrWhiteSpace(txtIDPT.Text) && int.TryParse(txtIDPT.Text, out int patientId))
                    results = results.Where(a => a.Patient.Id == patientId).ToList();

                DateTime start = dtpStart.Value;
                DateTime end = dtpEnd.Value;
                DateTime date = dtpDate.Value;

                // Lọc theo khoảng thời gian
                results = results.Where(a => a.StartTime >= start && a.EndTime <= end).ToList();
                results = results.Where(a => a.Date.Date == date.Date).ToList();
                // Khi lọc: hiển thị danh sách tạm thời; khi xóa điều kiện có thể gọi LoadAppointments()
                guna2DataGridView1.DataSource = results;

                MessageBox.Show($"Tìm thấy {results.Count} kết quả.", "Kết quả",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi tìm kiếm: " + ex.Message,
                                "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //  Khi double click vào một dòng → điền thông tin vào TextBox
        private void Guna2DataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // tránh click header
            {
                var row = guna2DataGridView1.Rows[e.RowIndex].DataBoundItem as Appointment;
                if (row != null)
                {
                    txtAppointmentId.Text = row.Id.ToString();
                    txtIDDT.Text = row.Doctor.Id.ToString();
                    txtNameDoctor.Text = row.Doctor.Name;
                    txtSpecialty.Text = row.Doctor.Specialty;

                    txtIDPT.Text = row.Patient.Id.ToString();
                    txtNamePatient.Text = row.Patient.Name;
                    txtAge.Text = row.Patient.Age.ToString();
                    if (cboPatientType != null) cboPatientType.SelectedItem = row.Patient.PatientType;
                    if (txtNotes != null) txtNotes.Text = row.Notes ?? "";

                    dtpStart.Value = row.StartTime;
                    dtpEnd.Value = row.EndTime;
                    dtpDate.Value = row.Date;
                }

            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                // Xóa nội dung các TextBox
                txtAppointmentId.Clear();
                txtNameDoctor.Clear();
                txtIDDT.Clear();
                txtSpecialty.Clear();
                txtNamePatient.Clear();
                txtIDPT.Clear();
                txtAge.Clear();
                txtNotes.Clear();

                // Reset ComboBox & DateTimePicker
                cboPatientType.SelectedIndex = -1;
                dtpStart.Value = DateTime.Now;
                dtpEnd.Value = DateTime.Now;
                dtpDate.Value = DateTime.Now;

                // Nạp lại danh sách lịch hẹn đầy đủ
                LoadAppointments();

                MessageBox.Show("Đã làm mới nội dung nhập và tải lại danh sách.", "Làm mới",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi làm mới: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
