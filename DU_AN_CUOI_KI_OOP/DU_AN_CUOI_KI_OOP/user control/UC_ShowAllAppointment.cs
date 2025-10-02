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
            guna2DataGridView1.DataSource = repo.GetAllAppointments();
        }

        private void UC_ShowAllAppointment_Load_1(object sender, EventArgs e)
        {

        }
    }
}

