using System;
using System.Windows.Forms;

namespace DU_AN_CUOI_KI_OOP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            uC_AddAppointment1.Hide();
            uC_EditAppointment1.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAddAppointment_Click(object sender, EventArgs e)
        {
            uC_AddAppointment1.Show();
            uC_AddAppointment1.BringToFront();
            uC_EditAppointment1.Hide();
        }

        private void btnEditAppointment_Click(object sender, EventArgs e)
        {
            uC_EditAppointment1.Show();
            uC_EditAppointment1.BringToFront();
            uC_AddAppointment1.Hide();
        }
    }
}