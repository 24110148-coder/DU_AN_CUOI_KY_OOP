using System;
using System.Windows.Forms;
using DU_AN_CUOI_KI_OOP.Data;
using DU_AN_CUOI_KI_OOP.Models;

namespace DU_AN_CUOI_KI_OOP.user_control
{
    public partial class UC_AddAppointment : UserControl
    {
        private readonly AppointmentRepository repo = new AppointmentRepository();

        public UC_AddAppointment()
        {
            InitializeComponent();

            // DateTimePicker Start
            dtpStart.Format = DateTimePickerFormat.Custom;
            dtpStart.CustomFormat = "HH:mm";
            dtpStart.ShowUpDown = true;

            // DateTimePicker End
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
                MessageBox.Show("Không thể tải dữ liệu lịch hẹn: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnAddAppointment_Click(object sender, EventArgs e)
        {
            try
            {
                // ==== 1️⃣ Kiểm tra dữ liệu bắt buộc ====
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

                // ==== 2️⃣ Kiểm tra kiểu dữ liệu số ====
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

                // ==== 3️⃣ Kiểm tra thời gian ====
                DateTime startTime = dtpStart.Value;
                DateTime endTime = dtpEnd.Value;
                if (endTime <= startTime)
                {
                    MessageBox.Show("Thời gian kết thúc phải sau thời gian bắt đầu.",
                        "Kiểm tra thời gian", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // ==== 4️⃣ Tạo đối tượng Doctor & Patient (kế thừa Person) ====
                var doctor = new Doctor
                {
                    Id = doctorId,
                    Name = txtNameDoctor.Text.Trim(),
                    Specialty = txtSpecialty.Text.Trim()
                };

                var patient = new Patient
                {
                    Id = patientId,
                    Name = txtNamePatient.Text.Trim(),
                    Age = age
                };

                // ==== 5️⃣ Tạo lịch hẹn ====
                var appointment = new Appointment
                {
                    Doctor = doctor,
                    Patient = patient,
                    Date = dtpDate.Value,
                    StartTime = startTime,
                    EndTime = endTime,
                    Notes = ""
                };

                // ==== 6️⃣ Lưu và cập nhật ====
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

        // 🧹 Hàm dọn dữ liệu sau khi thêm
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

        // 📋 Hiển thị danh sách lịch hẹn hiện có
        private void LoadAppointments()
        {
            guna2DataGridView1.AutoGenerateColumns = true;
            guna2DataGridView1.DataSource = repo.GetBindingList();

            // Ẩn các cột phức hợp
            if (guna2DataGridView1.Columns.Contains("Doctor"))
                guna2DataGridView1.Columns["Doctor"].Visible = false;
            if (guna2DataGridView1.Columns.Contains("Patient"))
                guna2DataGridView1.Columns["Patient"].Visible = false;

            // Cập nhật tiêu đề cột
            SetColumnOrder();
        }

        // 🧭 Thiết lập thứ tự & tiêu đề cột
        private void SetColumnOrder()
        {
            // Thiết lập thứ tự cột theo thứ tự mong muốn
            if (guna2DataGridView1.Columns.Contains("Id"))
            {
                guna2DataGridView1.Columns["Id"].HeaderText = "ID";
                guna2DataGridView1.Columns["Id"].DisplayIndex = 0;
            }
            if (guna2DataGridView1.Columns.Contains("DoctorName"))
            {
                guna2DataGridView1.Columns["DoctorName"].HeaderText = "Doctor Name";
                guna2DataGridView1.Columns["DoctorName"].DisplayIndex = 1;
            }
            if (guna2DataGridView1.Columns.Contains("DoctorId"))
            {
                guna2DataGridView1.Columns["DoctorId"].HeaderText = "Doctor ID";
                guna2DataGridView1.Columns["DoctorId"].DisplayIndex = 2;
            }
            if (guna2DataGridView1.Columns.Contains("PatientName"))
            {
                guna2DataGridView1.Columns["PatientName"].HeaderText = "Patient Name";
                guna2DataGridView1.Columns["PatientName"].DisplayIndex = 3;
            }
            if (guna2DataGridView1.Columns.Contains("PatientId"))
            {
                guna2DataGridView1.Columns["PatientId"].HeaderText = "Patient ID";
                guna2DataGridView1.Columns["PatientId"].DisplayIndex = 4;
            }
            if (guna2DataGridView1.Columns.Contains("StartTime"))
            {
                guna2DataGridView1.Columns["StartTime"].HeaderText = "StartTime";
                guna2DataGridView1.Columns["StartTime"].DisplayIndex = 5;
            }
            if (guna2DataGridView1.Columns.Contains("EndTime"))
            {
                guna2DataGridView1.Columns["EndTime"].HeaderText = "EndTime";
                guna2DataGridView1.Columns["EndTime"].DisplayIndex = 6;
            }
            if (guna2DataGridView1.Columns.Contains("Date"))
            {
                guna2DataGridView1.Columns["Date"].HeaderText = "Date";
                guna2DataGridView1.Columns["Date"].DisplayIndex = 7;
            }
            if (guna2DataGridView1.Columns.Contains("Notes"))
            {
                guna2DataGridView1.Columns["Notes"].HeaderText = "Note";
                guna2DataGridView1.Columns["Notes"].DisplayIndex = 8;
            }
        }
    }
}
