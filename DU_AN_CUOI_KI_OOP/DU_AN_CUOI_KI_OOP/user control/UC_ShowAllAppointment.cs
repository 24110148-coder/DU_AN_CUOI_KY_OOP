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
    public partial class UC_ShowAllAppointment : UserControl
    {
        public UC_ShowAllAppointment()
        {
            InitializeComponent();
            this.Load += UC_ShowAllAppointment_Load;
            this.btnRefresh.Click += BtnRefresh_Click;
        }

        private void UC_ShowAllAppointment_Load(object sender, EventArgs e)
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

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                LoadAppointments();
                MessageBox.Show("Đã làm mới danh sách.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi làm mới: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadAppointments()
        {
            var repo = new AppointmentRepository();
            guna2DataGridView1.AutoGenerateColumns = true;
            // Bind trực tiếp vào BindingList để tự động đồng bộ giữa các UC
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

        private void UC_ShowAllAppointment_Load_1(object sender, EventArgs e)
        {

        }
    }
}

