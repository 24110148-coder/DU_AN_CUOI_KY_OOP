using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DU_AN_CUOI_KI_OOP.Data;
using DU_AN_CUOI_KI_OOP.Models;

namespace DU_AN_CUOI_KI_OOP.user_control
{

    public partial class UC_EditAppointment : UserControl
    {
        private readonly AppointmentRepository repo = new AppointmentRepository();

        public UC_EditAppointment()
        {
            InitializeComponent();
            this.Load += UC_EditAppointment_Load;
            this.btnEditAppointment.Click += BtnEditAppointment_Click;
            dtpStart.Format = DateTimePickerFormat.Custom;
            dtpStart.CustomFormat = "HH:mm";
            dtpStart.ShowUpDown = true;

            dtpEnd.Format = DateTimePickerFormat.Custom;
            dtpEnd.CustomFormat = "HH:mm";
            dtpEnd.ShowUpDown = true;
            this.guna2DataGridView1.CellDoubleClick += Guna2DataGridView1_CellDoubleClick;
            this.VisibleChanged += UC_RemoveAppointment_VisibleChanged;
        }
        private void UC_RemoveAppointment_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible)
            {
                LoadAppointments(); // tự động refresh khi quay lại tab/UC này
            }
        }
        private void Guna2DataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // tránh click header
            {
                var row = guna2DataGridView1.Rows[e.RowIndex].DataBoundItem as Appointment;
                if (row != null)
                {
                    txtIDDT.Text = row.Doctor.Id.ToString();
                    txtNameDoctor.Text = row.Doctor.Name;
                    txtIDPT.Text = row.Patient.Id.ToString();
                    txtNamePatient.Text = row.Patient.Name;
                    dtpStart.Value = row.StartTime;
                    dtpEnd.Value = row.EndTime;
                    dtpDate.Value = row.Date;

                }
            }
        }

        private void UC_EditAppointment_Load(object sender, EventArgs e)
        {
            try
            {
                LoadAppointments();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể tải dữ liệu lịch hẹn: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadAppointments()
        {
            guna2DataGridView1.AutoGenerateColumns = true;
            // Bind trực tiếp vào BindingList để tự động cập nhật
            guna2DataGridView1.DataSource = repo.GetBindingList();
            if (guna2DataGridView1.Columns.Contains("Doctor"))
                guna2DataGridView1.Columns["Doctor"].Visible = false;
            if (guna2DataGridView1.Columns.Contains("Patient"))
                guna2DataGridView1.Columns["Patient"].Visible = false;
            if (guna2DataGridView1.Columns.Contains("Id"))
            {
                guna2DataGridView1.Columns["Id"].HeaderText = "ID";
                guna2DataGridView1.Columns["Id"].DisplayIndex = 0;
            }
            if (guna2DataGridView1.Columns.Contains("DoctorId"))
            {
                guna2DataGridView1.Columns["DoctorId"].HeaderText = "Doctor ID";
                guna2DataGridView1.Columns["DoctorId"].DisplayIndex = 2;
            }
            if (guna2DataGridView1.Columns.Contains("DoctorName"))
            {
                guna2DataGridView1.Columns["DoctorName"].HeaderText = "Doctor Name";
                guna2DataGridView1.Columns["DoctorName"].DisplayIndex = 1;
            }
            if (guna2DataGridView1.Columns.Contains("PatientId"))
            {
                guna2DataGridView1.Columns["PatientId"].HeaderText = "Patient ID";
                guna2DataGridView1.Columns["PatientId"].DisplayIndex = 4;
            }
            if (guna2DataGridView1.Columns.Contains("PatientName"))
            {
                guna2DataGridView1.Columns["PatientName"].HeaderText = "Patient Name";
                guna2DataGridView1.Columns["PatientName"].DisplayIndex = 3;
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

        private void BtnEditAppointment_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtNameDoctor.Text) ||
                    string.IsNullOrWhiteSpace(txtIDDT.Text) ||
                    string.IsNullOrWhiteSpace(txtNamePatient.Text) ||
                    string.IsNullOrWhiteSpace(txtIDPT.Text))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Thiếu dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DateTime startTime = dtpStart.Value;
                DateTime endTime = dtpEnd.Value;
                DateTime date = dtpDate.Value;

                if (endTime <= startTime)
                {
                    MessageBox.Show("Thời gian kết thúc phải sau thời gian bắt đầu.",
                        "Kiểm tra thời gian", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }


                // Tạo doctor và patient
                var doctor = new Doctor
                {
                    Id = int.Parse(txtIDDT.Text.Trim()),
                    Name = txtNameDoctor.Text.Trim(),
                    Specialty = ""
                };

                var patient = new Patient
                {
                    Id = int.Parse(txtIDPT.Text.Trim()),
                    Name = txtNamePatient.Text.Trim(),
                    Age = 0
                };

                // Tạo appointment
                var appointment = new Appointment
                {
                    Id = int.Parse(txtAppointmentId.Text.Trim()), // textbox chứa ID lịch hẹn
                    Doctor = doctor,
                    Patient = patient,
                    StartTime = startTime,
                    EndTime = endTime,
                    Date = date,
                    Notes = "" // nếu bạn có thêm textbox Notes thì thay vào đây
                };


                //var repo = new AppointmentRepository();
                repo.UpdateAppointment(appointment);

                MessageBox.Show("Cập nhật lịch hẹn thành công.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadAppointments();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void UC_EditAppointment_Load_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
