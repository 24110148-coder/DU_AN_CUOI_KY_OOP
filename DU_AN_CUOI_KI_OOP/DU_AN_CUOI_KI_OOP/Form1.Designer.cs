namespace DU_AN_CUOI_KI_OOP
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.btnExit = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnShowAllAppointment = new Guna.UI2.WinForms.Guna2Button();
            this.btnSearchAppointment = new Guna.UI2.WinForms.Guna2Button();
            this.btnRemoveAppointment = new Guna.UI2.WinForms.Guna2Button();
            this.btnEditAppointment = new Guna.UI2.WinForms.Guna2Button();
            this.btnAddAppointment = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.uC_ShowAllAppointment1 = new DU_AN_CUOI_KI_OOP.user_control.UC_ShowAllAppointment();
            this.uC_RemoveAppointment1 = new DU_AN_CUOI_KI_OOP.user_control.UC_RemoveAppointment();
            this.uC_SearchAppointment1 = new DU_AN_CUOI_KI_OOP.user_control.UC_SearchAppointment();
            this.uC_EditAppointment1 = new DU_AN_CUOI_KI_OOP.user_control.UC_EditAppointment();
            this.uC_AddAppointment1 = new DU_AN_CUOI_KI_OOP.user_control.UC_AddAppointment();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnExit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnExit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnExit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Red;
            this.btnExit.Location = new System.Drawing.Point(12, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(42, 40);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "X";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.btnShowAllAppointment);
            this.guna2Panel1.Controls.Add(this.btnSearchAppointment);
            this.guna2Panel1.Controls.Add(this.btnRemoveAppointment);
            this.guna2Panel1.Controls.Add(this.btnEditAppointment);
            this.guna2Panel1.Controls.Add(this.btnAddAppointment);
            this.guna2Panel1.Location = new System.Drawing.Point(100, 12);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1260, 100);
            this.guna2Panel1.TabIndex = 1;
            // 
            // btnShowAllAppointment
            // 
            this.btnShowAllAppointment.BorderColor = System.Drawing.Color.Lime;
            this.btnShowAllAppointment.BorderRadius = 18;
            this.btnShowAllAppointment.BorderThickness = 2;
            this.btnShowAllAppointment.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnShowAllAppointment.CheckedState.BorderColor = System.Drawing.Color.Lime;
            this.btnShowAllAppointment.CheckedState.CustomBorderColor = System.Drawing.Color.Cyan;
            this.btnShowAllAppointment.CheckedState.FillColor = System.Drawing.Color.Blue;
            this.btnShowAllAppointment.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnShowAllAppointment.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnShowAllAppointment.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnShowAllAppointment.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnShowAllAppointment.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnShowAllAppointment.ForeColor = System.Drawing.Color.White;
            this.btnShowAllAppointment.Location = new System.Drawing.Point(1011, 19);
            this.btnShowAllAppointment.Name = "btnShowAllAppointment";
            this.btnShowAllAppointment.Size = new System.Drawing.Size(180, 61);
            this.btnShowAllAppointment.TabIndex = 4;
            this.btnShowAllAppointment.Text = "Show All Appointment";
            this.btnShowAllAppointment.Click += new System.EventHandler(this.btnShowAllAppointment_Click);
            // 
            // btnSearchAppointment
            // 
            this.btnSearchAppointment.BorderColor = System.Drawing.Color.Lime;
            this.btnSearchAppointment.BorderRadius = 18;
            this.btnSearchAppointment.BorderThickness = 2;
            this.btnSearchAppointment.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnSearchAppointment.CheckedState.BorderColor = System.Drawing.Color.Lime;
            this.btnSearchAppointment.CheckedState.CustomBorderColor = System.Drawing.Color.Cyan;
            this.btnSearchAppointment.CheckedState.FillColor = System.Drawing.Color.Blue;
            this.btnSearchAppointment.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSearchAppointment.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSearchAppointment.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSearchAppointment.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSearchAppointment.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnSearchAppointment.ForeColor = System.Drawing.Color.White;
            this.btnSearchAppointment.Location = new System.Drawing.Point(770, 19);
            this.btnSearchAppointment.Name = "btnSearchAppointment";
            this.btnSearchAppointment.Size = new System.Drawing.Size(180, 61);
            this.btnSearchAppointment.TabIndex = 3;
            this.btnSearchAppointment.Text = "Search Appointment";
            this.btnSearchAppointment.Click += new System.EventHandler(this.btnSearchAppointment_Click);
            // 
            // btnRemoveAppointment
            // 
            this.btnRemoveAppointment.BorderColor = System.Drawing.Color.Lime;
            this.btnRemoveAppointment.BorderRadius = 18;
            this.btnRemoveAppointment.BorderThickness = 2;
            this.btnRemoveAppointment.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnRemoveAppointment.CheckedState.BorderColor = System.Drawing.Color.Lime;
            this.btnRemoveAppointment.CheckedState.CustomBorderColor = System.Drawing.Color.Cyan;
            this.btnRemoveAppointment.CheckedState.FillColor = System.Drawing.Color.Blue;
            this.btnRemoveAppointment.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRemoveAppointment.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRemoveAppointment.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRemoveAppointment.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRemoveAppointment.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnRemoveAppointment.ForeColor = System.Drawing.Color.White;
            this.btnRemoveAppointment.Location = new System.Drawing.Point(523, 19);
            this.btnRemoveAppointment.Name = "btnRemoveAppointment";
            this.btnRemoveAppointment.Size = new System.Drawing.Size(180, 61);
            this.btnRemoveAppointment.TabIndex = 2;
            this.btnRemoveAppointment.Text = "Remove Appointment";
            this.btnRemoveAppointment.Click += new System.EventHandler(this.btnRemoveAppointment_Click);
            // 
            // btnEditAppointment
            // 
            this.btnEditAppointment.BorderColor = System.Drawing.Color.Lime;
            this.btnEditAppointment.BorderRadius = 18;
            this.btnEditAppointment.BorderThickness = 2;
            this.btnEditAppointment.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnEditAppointment.CheckedState.BorderColor = System.Drawing.Color.Lime;
            this.btnEditAppointment.CheckedState.CustomBorderColor = System.Drawing.Color.Cyan;
            this.btnEditAppointment.CheckedState.FillColor = System.Drawing.Color.Blue;
            this.btnEditAppointment.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btnEditAppointment.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEditAppointment.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEditAppointment.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEditAppointment.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEditAppointment.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditAppointment.ForeColor = System.Drawing.Color.White;
            this.btnEditAppointment.Location = new System.Drawing.Point(288, 19);
            this.btnEditAppointment.Name = "btnEditAppointment";
            this.btnEditAppointment.Size = new System.Drawing.Size(180, 61);
            this.btnEditAppointment.TabIndex = 1;
            this.btnEditAppointment.Text = "Edit Appointment";
            this.btnEditAppointment.Click += new System.EventHandler(this.btnEditAppointment_Click);
            // 
            // btnAddAppointment
            // 
            this.btnAddAppointment.BorderColor = System.Drawing.Color.Lime;
            this.btnAddAppointment.BorderRadius = 18;
            this.btnAddAppointment.BorderThickness = 2;
            this.btnAddAppointment.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnAddAppointment.CheckedState.BorderColor = System.Drawing.Color.Lime;
            this.btnAddAppointment.CheckedState.CustomBorderColor = System.Drawing.Color.Cyan;
            this.btnAddAppointment.CheckedState.FillColor = System.Drawing.Color.Blue;
            this.btnAddAppointment.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btnAddAppointment.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddAppointment.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddAppointment.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddAppointment.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddAppointment.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddAppointment.ForeColor = System.Drawing.Color.White;
            this.btnAddAppointment.Location = new System.Drawing.Point(46, 19);
            this.btnAddAppointment.Name = "btnAddAppointment";
            this.btnAddAppointment.Size = new System.Drawing.Size(180, 61);
            this.btnAddAppointment.TabIndex = 0;
            this.btnAddAppointment.Text = "Add Appointment";
            this.btnAddAppointment.Click += new System.EventHandler(this.btnAddAppointment_Click);
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Controls.Add(this.uC_ShowAllAppointment1);
            this.guna2Panel2.Controls.Add(this.uC_RemoveAppointment1);
            this.guna2Panel2.Controls.Add(this.uC_SearchAppointment1);
            this.guna2Panel2.Controls.Add(this.uC_EditAppointment1);
            this.guna2Panel2.Controls.Add(this.uC_AddAppointment1);
            this.guna2Panel2.Location = new System.Drawing.Point(51, 173);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(1460, 776);
            this.guna2Panel2.TabIndex = 2;
            // 
            // uC_ShowAllAppointment1
            // 
            this.uC_ShowAllAppointment1.Location = new System.Drawing.Point(0, -3);
            this.uC_ShowAllAppointment1.Name = "uC_ShowAllAppointment1";
            this.uC_ShowAllAppointment1.Size = new System.Drawing.Size(1460, 776);
            this.uC_ShowAllAppointment1.TabIndex = 4;
            // 
            // uC_RemoveAppointment1
            // 
            this.uC_RemoveAppointment1.Location = new System.Drawing.Point(0, 0);
            this.uC_RemoveAppointment1.Name = "uC_RemoveAppointment1";
            this.uC_RemoveAppointment1.Size = new System.Drawing.Size(1460, 776);
            this.uC_RemoveAppointment1.TabIndex = 3;
            // 
            // uC_SearchAppointment1
            // 
            this.uC_SearchAppointment1.Location = new System.Drawing.Point(0, 0);
            this.uC_SearchAppointment1.Name = "uC_SearchAppointment1";
            this.uC_SearchAppointment1.Size = new System.Drawing.Size(1460, 776);
            this.uC_SearchAppointment1.TabIndex = 2;
            // 
            // uC_EditAppointment1
            // 
            this.uC_EditAppointment1.Location = new System.Drawing.Point(0, 0);
            this.uC_EditAppointment1.Name = "uC_EditAppointment1";
            this.uC_EditAppointment1.Size = new System.Drawing.Size(1460, 776);
            this.uC_EditAppointment1.TabIndex = 1;
            // 
            // uC_AddAppointment1
            // 
            this.uC_AddAppointment1.Location = new System.Drawing.Point(0, 0);
            this.uC_AddAppointment1.Name = "uC_AddAppointment1";
            this.uC_AddAppointment1.Size = new System.Drawing.Size(1460, 776);
            this.uC_AddAppointment1.TabIndex = 0;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1569, 976);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.btnExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private Guna.UI2.WinForms.Guna2Button btnExit;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button btnSearchAppointment;
        private Guna.UI2.WinForms.Guna2Button btnRemoveAppointment;
        private Guna.UI2.WinForms.Guna2Button btnEditAppointment;
        private Guna.UI2.WinForms.Guna2Button btnAddAppointment;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private user_control.UC_AddAppointment uC_AddAppointment1;
        private user_control.UC_EditAppointment uC_EditAppointment1;
        private Guna.UI2.WinForms.Guna2Button btnShowAllAppointment;
        private user_control.UC_SearchAppointment uC_SearchAppointment1;
        private user_control.UC_ShowAllAppointment uC_ShowAllAppointment1;
        private user_control.UC_RemoveAppointment uC_RemoveAppointment1;
    }
}

