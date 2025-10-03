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
    public partial class UC_RemoveAppointment : UserControl
    {
        private readonly AppointmentRepository repo = new AppointmentRepository();
        public UC_RemoveAppointment()
        {
            InitializeComponent();
            this.Load += UC_RemoveAppointment_Load;
            this.btnRemoveAppointment.Click += BtnRemoveAppointment_Click;
            dtpStart.Format = DateTimePickerFormat.Custom;
            dtpStart.CustomFormat = "HH:mm";
            dtpStart.ShowUpDown = true;

            dtpEnd.Format = DateTimePickerFormat.Custom;
            dtpEnd.CustomFormat = "HH:mm";
            dtpEnd.ShowUpDown = true;
            // Gắn sự kiện double click cho DataGridView
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

        private void UC_RemoveAppointment_Load(object sender, EventArgs e)
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
            // Bind trực tiếp vào BindingList để tự đồng bộ giữa các UC
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

        private void BtnRemoveAppointment_Click(object sender, EventArgs e)
        {
            try
            {
                var confirm = MessageBox.Show("Bạn có chắc chắn muốn xóa lịch hẹn này?",
                                              "Xác nhận",
                                              MessageBoxButtons.YesNo,
                                              MessageBoxIcon.Question);
                if (confirm != DialogResult.Yes)
                {
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtAppointmentId.Text))
                {
                    MessageBox.Show("Vui lòng nhập ID lịch hẹn cần xóa.",
                                    "Thiếu dữ liệu",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                    return;
                }

                int appointmentId = int.Parse(txtAppointmentId.Text.Trim());

                //var repo = new AppointmentRepository();
                repo.DeleteAppointment(appointmentId); 

                MessageBox.Show("Xóa lịch hẹn thành công.", "Thành công",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadAppointments();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message,
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

        private void UC_RemoveAppointment_Load_1(object sender, EventArgs e)
        {

        }
    }
}
