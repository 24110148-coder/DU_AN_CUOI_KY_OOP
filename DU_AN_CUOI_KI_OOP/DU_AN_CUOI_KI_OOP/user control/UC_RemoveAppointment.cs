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
                repo.DeleteAppointment(appointmentId); // ✅ chỉ truyền 1 tham số

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


        private void UC_RemoveAppointment_Load_1(object sender, EventArgs e)
        {

        }
    }
}
