namespace DU_AN_CUOI_KI_OOP.user_control
{
    partial class UC_SearchAppointment
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.labelHeader = new System.Windows.Forms.Label();
            this.panelRight = new Guna.UI2.WinForms.Guna2Panel();
            this.lblDoctorInfo = new System.Windows.Forms.Label();
            this.lblPatientInfo = new System.Windows.Forms.Label();
            this.lblAppointmentTime = new System.Windows.Forms.Label();
            this.txtNameDoctor = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtIDDT = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtSpecialty = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtNamePatient = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtIDPT = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtAge = new Guna.UI2.WinForms.Guna2TextBox();
            this.cboPatientType = new Guna.UI2.WinForms.Guna2ComboBox();
            this.dtpStart = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dtpEnd = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dtpDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.txtNotes = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblAppointmentInfo = new System.Windows.Forms.Label();
            this.txtAppointmentId = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnSeacrhAppointment = new Guna.UI2.WinForms.Guna2Button();
            this.guna2DataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btnRefresh = new Guna.UI2.WinForms.Guna2Button();
            this.panelRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelHeader
            // 
            this.labelHeader.AutoSize = true;
            this.labelHeader.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.labelHeader.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.labelHeader.Location = new System.Drawing.Point(30, 20);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Size = new System.Drawing.Size(281, 37);
            this.labelHeader.TabIndex = 2;
            this.labelHeader.Text = "Search Appointment";
            // 
            // panelRight
            // 
            this.panelRight.AutoScroll = true;
            this.panelRight.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelRight.BorderRadius = 10;
            this.panelRight.Controls.Add(this.btnRefresh);
            this.panelRight.Controls.Add(this.lblDoctorInfo);
            this.panelRight.Controls.Add(this.lblPatientInfo);
            this.panelRight.Controls.Add(this.lblAppointmentTime);
            this.panelRight.Controls.Add(this.txtNameDoctor);
            this.panelRight.Controls.Add(this.txtIDDT);
            this.panelRight.Controls.Add(this.txtSpecialty);
            this.panelRight.Controls.Add(this.txtNamePatient);
            this.panelRight.Controls.Add(this.txtIDPT);
            this.panelRight.Controls.Add(this.txtAge);
            this.panelRight.Controls.Add(this.cboPatientType);
            this.panelRight.Controls.Add(this.dtpStart);
            this.panelRight.Controls.Add(this.dtpEnd);
            this.panelRight.Controls.Add(this.dtpDate);
            this.panelRight.Controls.Add(this.txtNotes);
            this.panelRight.Controls.Add(this.lblAppointmentInfo);
            this.panelRight.Controls.Add(this.txtAppointmentId);
            this.panelRight.Controls.Add(this.btnSeacrhAppointment);
            this.panelRight.Location = new System.Drawing.Point(934, 75);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(480, 680);
            this.panelRight.TabIndex = 3;
            // 
            // lblDoctorInfo
            // 
            this.lblDoctorInfo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblDoctorInfo.Location = new System.Drawing.Point(24, 94);
            this.lblDoctorInfo.Name = "lblDoctorInfo";
            this.lblDoctorInfo.Size = new System.Drawing.Size(100, 23);
            this.lblDoctorInfo.TabIndex = 14;
            this.lblDoctorInfo.Text = "Doctor Information";
            // 
            // lblPatientInfo
            // 
            this.lblPatientInfo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblPatientInfo.Location = new System.Drawing.Point(24, 219);
            this.lblPatientInfo.Name = "lblPatientInfo";
            this.lblPatientInfo.Size = new System.Drawing.Size(100, 23);
            this.lblPatientInfo.TabIndex = 15;
            this.lblPatientInfo.Text = "Patient Information";
            // 
            // lblAppointmentTime
            // 
            this.lblAppointmentTime.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblAppointmentTime.Location = new System.Drawing.Point(24, 359);
            this.lblAppointmentTime.Name = "lblAppointmentTime";
            this.lblAppointmentTime.Size = new System.Drawing.Size(172, 23);
            this.lblAppointmentTime.TabIndex = 16;
            this.lblAppointmentTime.Text = "Appointment Time";
            // 
            // txtNameDoctor
            // 
            this.txtNameDoctor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNameDoctor.DefaultText = "";
            this.txtNameDoctor.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNameDoctor.Location = new System.Drawing.Point(24, 124);
            this.txtNameDoctor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNameDoctor.Name = "txtNameDoctor";
            this.txtNameDoctor.PlaceholderText = "Doctor\'s Name";
            this.txtNameDoctor.SelectedText = "";
            this.txtNameDoctor.Size = new System.Drawing.Size(280, 36);
            this.txtNameDoctor.TabIndex = 17;
            // 
            // txtIDDT
            // 
            this.txtIDDT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIDDT.DefaultText = "";
            this.txtIDDT.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtIDDT.Location = new System.Drawing.Point(324, 124);
            this.txtIDDT.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtIDDT.Name = "txtIDDT";
            this.txtIDDT.PlaceholderText = "ID";
            this.txtIDDT.SelectedText = "";
            this.txtIDDT.Size = new System.Drawing.Size(120, 36);
            this.txtIDDT.TabIndex = 18;
            // 
            // txtSpecialty
            // 
            this.txtSpecialty.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSpecialty.DefaultText = "";
            this.txtSpecialty.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSpecialty.Location = new System.Drawing.Point(24, 169);
            this.txtSpecialty.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSpecialty.Name = "txtSpecialty";
            this.txtSpecialty.PlaceholderText = "Specialty";
            this.txtSpecialty.SelectedText = "";
            this.txtSpecialty.Size = new System.Drawing.Size(420, 36);
            this.txtSpecialty.TabIndex = 19;
            // 
            // txtNamePatient
            // 
            this.txtNamePatient.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNamePatient.DefaultText = "";
            this.txtNamePatient.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNamePatient.Location = new System.Drawing.Point(24, 249);
            this.txtNamePatient.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNamePatient.Name = "txtNamePatient";
            this.txtNamePatient.PlaceholderText = "Patient\'s Name";
            this.txtNamePatient.SelectedText = "";
            this.txtNamePatient.Size = new System.Drawing.Size(280, 36);
            this.txtNamePatient.TabIndex = 20;
            // 
            // txtIDPT
            // 
            this.txtIDPT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIDPT.DefaultText = "";
            this.txtIDPT.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtIDPT.Location = new System.Drawing.Point(324, 249);
            this.txtIDPT.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtIDPT.Name = "txtIDPT";
            this.txtIDPT.PlaceholderText = "ID";
            this.txtIDPT.SelectedText = "";
            this.txtIDPT.Size = new System.Drawing.Size(120, 36);
            this.txtIDPT.TabIndex = 21;
            // 
            // txtAge
            // 
            this.txtAge.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAge.DefaultText = "";
            this.txtAge.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtAge.Location = new System.Drawing.Point(24, 294);
            this.txtAge.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAge.Name = "txtAge";
            this.txtAge.PlaceholderText = "Age";
            this.txtAge.SelectedText = "";
            this.txtAge.Size = new System.Drawing.Size(120, 36);
            this.txtAge.TabIndex = 22;
            // 
            // cboPatientType
            // 
            this.cboPatientType.BackColor = System.Drawing.Color.Transparent;
            this.cboPatientType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboPatientType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPatientType.FocusedColor = System.Drawing.Color.Empty;
            this.cboPatientType.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboPatientType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboPatientType.ItemHeight = 30;
            this.cboPatientType.Items.AddRange(new object[] {
            "Normal",
            "Inpatient",
            "Outpatient",
            "Emergency"});
            this.cboPatientType.Location = new System.Drawing.Point(164, 294);
            this.cboPatientType.Name = "cboPatientType";
            this.cboPatientType.Size = new System.Drawing.Size(280, 36);
            this.cboPatientType.TabIndex = 23;
            // 
            // dtpStart
            // 
            this.dtpStart.Checked = true;
            this.dtpStart.FillColor = System.Drawing.Color.Yellow;
            this.dtpStart.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpStart.Location = new System.Drawing.Point(24, 389);
            this.dtpStart.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpStart.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(200, 36);
            this.dtpStart.TabIndex = 24;
            this.dtpStart.Value = new System.DateTime(2025, 10, 16, 20, 6, 38, 912);
            // 
            // dtpEnd
            // 
            this.dtpEnd.Checked = true;
            this.dtpEnd.FillColor = System.Drawing.Color.Yellow;
            this.dtpEnd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpEnd.Location = new System.Drawing.Point(244, 389);
            this.dtpEnd.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpEnd.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(200, 36);
            this.dtpEnd.TabIndex = 25;
            this.dtpEnd.Value = new System.DateTime(2025, 10, 16, 20, 6, 46, 511);
            // 
            // dtpDate
            // 
            this.dtpDate.Checked = true;
            this.dtpDate.FillColor = System.Drawing.Color.Yellow;
            this.dtpDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpDate.Location = new System.Drawing.Point(24, 434);
            this.dtpDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(420, 36);
            this.dtpDate.TabIndex = 26;
            this.dtpDate.Value = new System.DateTime(2025, 10, 16, 20, 3, 20, 32);
            // 
            // txtNotes
            // 
            this.txtNotes.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNotes.DefaultText = "";
            this.txtNotes.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNotes.Location = new System.Drawing.Point(24, 484);
            this.txtNotes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.PlaceholderText = "Notes";
            this.txtNotes.SelectedText = "";
            this.txtNotes.Size = new System.Drawing.Size(420, 100);
            this.txtNotes.TabIndex = 27;
            // 
            // lblAppointmentInfo
            // 
            this.lblAppointmentInfo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblAppointmentInfo.Location = new System.Drawing.Point(20, 15);
            this.lblAppointmentInfo.Name = "lblAppointmentInfo";
            this.lblAppointmentInfo.Size = new System.Drawing.Size(176, 23);
            this.lblAppointmentInfo.TabIndex = 0;
            this.lblAppointmentInfo.Text = "Appointment ID";
            // 
            // txtAppointmentId
            // 
            this.txtAppointmentId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAppointmentId.DefaultText = "";
            this.txtAppointmentId.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtAppointmentId.Location = new System.Drawing.Point(20, 45);
            this.txtAppointmentId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAppointmentId.Name = "txtAppointmentId";
            this.txtAppointmentId.PlaceholderText = "Enter Appointment ID";
            this.txtAppointmentId.SelectedText = "";
            this.txtAppointmentId.Size = new System.Drawing.Size(420, 36);
            this.txtAppointmentId.TabIndex = 1;
            // 
            // btnSeacrhAppointment
            // 
            this.btnSeacrhAppointment.BorderRadius = 10;
            this.btnSeacrhAppointment.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnSeacrhAppointment.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSeacrhAppointment.ForeColor = System.Drawing.Color.White;
            this.btnSeacrhAppointment.Location = new System.Drawing.Point(211, 595);
            this.btnSeacrhAppointment.Name = "btnSeacrhAppointment";
            this.btnSeacrhAppointment.Size = new System.Drawing.Size(229, 50);
            this.btnSeacrhAppointment.TabIndex = 12;
            this.btnSeacrhAppointment.Text = "Search Appointment";
            // 
            // guna2DataGridView1
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.guna2DataGridView1.ColumnHeadersHeight = 35;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.guna2DataGridView1.DefaultCellStyle = dataGridViewCellStyle6;
            this.guna2DataGridView1.GridColor = System.Drawing.Color.LightGray;
            this.guna2DataGridView1.Location = new System.Drawing.Point(30, 75);
            this.guna2DataGridView1.Name = "guna2DataGridView1";
            this.guna2DataGridView1.RowHeadersVisible = false;
            this.guna2DataGridView1.RowHeadersWidth = 51;
            this.guna2DataGridView1.Size = new System.Drawing.Size(881, 680);
            this.guna2DataGridView1.TabIndex = 4;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.GridColor = System.Drawing.Color.LightGray;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.Height = 35;
            this.guna2DataGridView1.ThemeStyle.ReadOnly = false;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.Height = 22;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // btnRefresh
            // 
            this.btnRefresh.BorderRadius = 10;
            this.btnRefresh.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(24, 600);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(168, 45);
            this.btnRefresh.TabIndex = 28;
            this.btnRefresh.Text = "Refresh ";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // UC_SearchAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelRight);
            this.Controls.Add(this.guna2DataGridView1);
            this.Controls.Add(this.labelHeader);
            this.Name = "UC_SearchAppointment";
            this.Size = new System.Drawing.Size(1460, 776);
            this.Load += new System.EventHandler(this.UC_SearchAppointment_Load);
            this.panelRight.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelHeader;
        private Guna.UI2.WinForms.Guna2Panel panelRight;
        private System.Windows.Forms.Label lblDoctorInfo;
        private System.Windows.Forms.Label lblPatientInfo;
        private System.Windows.Forms.Label lblAppointmentTime;
        private Guna.UI2.WinForms.Guna2TextBox txtNameDoctor;
        private Guna.UI2.WinForms.Guna2TextBox txtIDDT;
        private Guna.UI2.WinForms.Guna2TextBox txtSpecialty;
        private Guna.UI2.WinForms.Guna2TextBox txtNamePatient;
        private Guna.UI2.WinForms.Guna2TextBox txtIDPT;
        private Guna.UI2.WinForms.Guna2TextBox txtAge;
        private Guna.UI2.WinForms.Guna2ComboBox cboPatientType;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpStart;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpEnd;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpDate;
        private Guna.UI2.WinForms.Guna2TextBox txtNotes;
        private System.Windows.Forms.Label lblAppointmentInfo;
        private Guna.UI2.WinForms.Guna2TextBox txtAppointmentId;
        private Guna.UI2.WinForms.Guna2Button btnSeacrhAppointment;
        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView1;
        private Guna.UI2.WinForms.Guna2Button btnRefresh;
    }
}
