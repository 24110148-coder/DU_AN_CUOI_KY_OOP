using DU_AN_CUOI_KI_OOP.Data;
using DU_AN_CUOI_KI_OOP.Models;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace DU_AN_CUOI_KI_OOP.user_control
{
    public partial class UC_AddAppointment : UserControl
    {
        private readonly AppointmentRepository repo = new AppointmentRepository();

        public UC_AddAppointment()
        {
            InitializeComponent();

            // 🕒 Cấu hình DateTimePicker Start
            dtpStart.Format = DateTimePickerFormat.Custom;
            dtpStart.CustomFormat = "HH:mm";
            dtpStart.ShowUpDown = true;

            // 🕒 Cấu hình DateTimePicker End
            dtpEnd.Format = DateTimePickerFormat.Custom;
            dtpEnd.CustomFormat = "HH:mm";
            dtpEnd.ShowUpDown = true;

            this.Load += UC_AddAppointment_Load;
            this.btnAddAppointment.Click += BtnAddAppointment_Click;
        }

        private void UC_AddAppointment_Load(object sender, EventArgs e)
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

        private void BtnAddAppointment_Click(object sender, EventArgs e)
        {
            try
            {
                // 🔸 Kiểm tra dữ liệu bắt buộc 
                if (string.IsNullOrWhiteSpace(txtIDDT.Text) ||
                    string.IsNullOrWhiteSpace(txtNameDoctor.Text) ||
                    string.IsNullOrWhiteSpace(txtSpecialty.Text) ||
                    string.IsNullOrWhiteSpace(txtIDPT.Text) ||
                    string.IsNullOrWhiteSpace(txtNamePatient.Text) ||
                    string.IsNullOrWhiteSpace(txtAge.Text))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin bác sĩ và bệnh nhân.",
                        "Thiếu dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // 🔸 Kiểm tra kiểu dữ liệu số 
                if (!int.TryParse(txtIDDT.Text.Trim(), out int doctorId))
                {
                    MessageBox.Show("Mã bác sĩ phải là số.", "Sai định dạng", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (!int.TryParse(txtIDPT.Text.Trim(), out int patientId))
                {
                    MessageBox.Show("Mã bệnh nhân phải là số.", "Sai định dạng", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (!int.TryParse(txtAge.Text.Trim(), out int age))
                {
                    MessageBox.Show("Tuổi bệnh nhân phải là số.", "Sai định dạng", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // 🔸 Kiểm tra thời gian 
                DateTime startTime = dtpStart.Value;
                DateTime endTime = dtpEnd.Value;
                if (endTime <= startTime)
                {
                    MessageBox.Show("Thời gian kết thúc phải sau thời gian bắt đầu.",
                        "Kiểm tra thời gian", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // 🔸 Tạo Doctor & Patient (đa hình)
                var doctor = new Doctor
                {
                    Id = doctorId,
                    Name = txtNameDoctor.Text.Trim(),
                    Specialty = txtSpecialty.Text.Trim()
                };

                var selectedType = (cboPatientType.SelectedItem ?? cboPatientType.Text ?? "Normal").ToString();
                var notes = txtNotes?.Text?.Trim() ?? "";

                var patient = Patient.FromType(
                    selectedType,
                    patientId,
                    txtNamePatient.Text.Trim(),
                    age,
                    notes
                );

                // 🔸 Tạo lịch hẹn
                var appointment = new Appointment
                {
                    Doctor = doctor,
                    Patient = patient,
                    Date = dtpDate.Value,
                    StartTime = startTime,
                    EndTime = endTime,
                    Notes = notes
                };

                // 🔸 Lưu và cập nhật
                repo.AddAppointment(appointment);
                MessageBox.Show("Thêm lịch hẹn thành công.", "Thành công",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadAppointments();
                ClearInputs();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message,
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 🧹 Dọn dữ liệu nhập
        private void ClearInputs()
        {
            txtIDDT.Clear();
            txtNameDoctor.Clear();
            txtSpecialty.Clear();
            txtIDPT.Clear();
            txtNamePatient.Clear();
            txtAge.Clear();
            dtpStart.Value = DateTime.Now;
            dtpEnd.Value = DateTime.Now;
            dtpDate.Value = DateTime.Now;
        }

        // 📋 Tải danh sách lịch hẹn
        private void LoadAppointments()
        {
            guna2DataGridView1.AutoGenerateColumns = false;
            SetupColumns(); // 👈 cấu hình cột thủ công

            guna2DataGridView1.DataSource = repo.GetBindingList();
        }

        // 🧭 Cấu hình cột theo thứ tự chuẩn
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

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                // Xóa nội dung các TextBox
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
