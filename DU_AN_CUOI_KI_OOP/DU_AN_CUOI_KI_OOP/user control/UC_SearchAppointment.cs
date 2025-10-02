using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DU_AN_CUOI_KI_OOP.Data;
using DU_AN_CUOI_KI_OOP.Models;

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

            // 🔹 Gắn sự kiện double click cho DataGridView
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
            var appointments = repo.GetAllAppointments().ToList();
            guna2DataGridView1.AutoGenerateColumns = true;
            guna2DataGridView1.DataSource = appointments;
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

                // Lọc theo khoảng thời gian
                results = results.Where(a => a.StartTime >= start && a.EndTime <= end).ToList();

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

        // 🔹 Khi double click vào một dòng → điền thông tin vào TextBox
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

                }
            }
        }
    }
}
