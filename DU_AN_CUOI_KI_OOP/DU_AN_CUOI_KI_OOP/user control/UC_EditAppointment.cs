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
            dtpStart.CustomFormat = "dd/MM/yyyy HH:mm";
            dtpStart.ShowUpDown = true;

            dtpEnd.Format = DateTimePickerFormat.Custom;
            dtpEnd.CustomFormat = "dd/MM/yyyy HH:mm";
            dtpEnd.ShowUpDown = true;

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
            //var repo = new AppointmentRepository();
            guna2DataGridView1.DataSource = repo.GetAllAppointments();
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
