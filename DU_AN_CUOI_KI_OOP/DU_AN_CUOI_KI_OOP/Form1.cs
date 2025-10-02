using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DU_AN_CUOI_KI_OOP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAddAppointment_Click(object sender, EventArgs e)
        {
            uC_AddAppointment1.Visible = true;
            uC_AddAppointment1.BringToFront();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            uC_AddAppointment1.Visible = false;
            btnAddAppointment.PerformClick();
        }

        private void btnEditAppointment_Click(object sender, EventArgs e)
        {
            uC_EditAppointment1.Visible = true;
            uC_EditAppointment1.BringToFront();
        }

        private void btnRemoveAppointment_Click(object sender, EventArgs e)
        {
            uC_RemoveAppointment1.Visible = true;   
            uC_RemoveAppointment1.BringToFront();
        }

        private void btnSearchAppointment_Click(object sender, EventArgs e)
        {
            uC_SearchAppointment1.Visible = true;   
            uC_SearchAppointment1.BringToFront();
        }

        private void btnShowAllAppointment_Click(object sender, EventArgs e)
        {
            uC_ShowAllAppointment1.Visible = true;  
            uC_ShowAllAppointment1.BringToFront();
        }
    }
}
