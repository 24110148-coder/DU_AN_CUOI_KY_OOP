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
            guna2DataGridView1.AutoGenerateColumns = true;
            // Mặc định hiển thị nguồn chung để giữ liên kết
            guna2DataGridView1.DataSource = repo.GetBindingList();
            
            // Ẩn các cột không cần thiết
            if (guna2DataGridView1.Columns.Contains("Doctor"))
                guna2DataGridView1.Columns["Doctor"].Visible = false;
            if (guna2DataGridView1.Columns.Contains("Patient"))
                guna2DataGridView1.Columns["Patient"].Visible = false;
            
            // Thiết lập thứ tự cột sau khi đã bind dữ liệu
            SetColumnOrder();
        }
        
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
                    txtIDPT.Text = row.Patient.Id.ToString();
                    txtNamePatient.Text = row.Patient.Name;
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
    }
}
