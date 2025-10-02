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
    public partial class UC_AddAppointment : UserControl
    {
        private readonly AppointmentRepository repo = new AppointmentRepository();

        public UC_AddAppointment()
        {
            InitializeComponent();
            // DateTimePicker Start
            dtpStart.Format = DateTimePickerFormat.Custom;
            dtpStart.CustomFormat = "dd/MM/yyyy HH:mm";  // hiển thị cả ngày giờ phút
            dtpStart.ShowUpDown = true;                  // dùng nút up/down để chỉnh giờ

            // DateTimePicker End
            dtpEnd.Format = DateTimePickerFormat.Custom;
            dtpEnd.CustomFormat = "dd/MM/yyyy HH:mm";
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
                MessageBox.Show("Không thể tải dữ liệu lịch hẹn: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnAddAppointment_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtNameDoctor.Text) ||
                    string.IsNullOrWhiteSpace(txtIDDT.Text) ||
                    string.IsNullOrWhiteSpace(txtNamePatient.Text) ||
                    string.IsNullOrWhiteSpace(txtIDPT.Text) )
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Thiếu dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DateTime startTime = dtpStart.Value;
                DateTime endTime = dtpEnd.Value;
            
                if (endTime <= startTime)
                {
                    MessageBox.Show("Thời gian kết thúc phải sau thời gian bắt đầu.", "Kiểm tra thời gian", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var doctor = new Doctor
                {
                    Id = int.Parse(txtIDDT.Text.Trim()),
                    Name = txtNameDoctor.Text.Trim(),
                    Specialty = "" // nếu bạn có textbox chuyên khoa thì thay vào đây
                };

                var patient = new Patient
                {
                    Id = int.Parse(txtIDPT.Text.Trim()),
                    Name = txtNamePatient.Text.Trim(),
                    Age = 0 // nếu có textbox tuổi thì thay vào đây
                };

                var appointment = new Appointment
                {
                    Doctor = doctor,
                    Patient = patient,
                    StartTime = startTime,
                    EndTime = endTime,
                    Notes = "" // nếu có textbox ghi chú thì thay vào
                };


                //var repo = new AppointmentRepository();
                repo.AddAppointment(appointment);

                MessageBox.Show("Thêm lịch hẹn thành công.", "Thành công",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadAppointments();
                ClearInputs();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearInputs()
        {
            txtNameDoctor.Text = string.Empty;
            txtIDDT.Text = string.Empty;
            txtNamePatient.Text = string.Empty;
            txtIDPT.Text = string.Empty;
            dtpStart.Value = DateTime.Now;
            dtpEnd.Value = DateTime.Now;
        }
        private void LoadAppointments()
        {
            guna2DataGridView1.AutoGenerateColumns = true;
            // Bind trực tiếp vào BindingList để luôn đồng bộ với các UC khác
            guna2DataGridView1.DataSource = repo.GetBindingList();


        }

    }
}
