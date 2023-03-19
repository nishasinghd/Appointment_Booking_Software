namespace Assignment_Two
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtProvince = new System.Windows.Forms.TextBox();
            this.txtPhoneNum = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblPatientName = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblProvince = new System.Windows.Forms.Label();
            this.lblPostalCode = new System.Windows.Forms.Label();
            this.lblPhoneNum = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblBirthDate = new System.Windows.Forms.Label();
            this.dateTimeBirth = new System.Windows.Forms.DateTimePicker();
            this.dateTimeAppTime = new System.Windows.Forms.DateTimePicker();
            this.lblReqAppTime = new System.Windows.Forms.Label();
            this.lblAppDur = new System.Windows.Forms.Label();
            this.lblPurpose = new System.Windows.Forms.Label();
            this.txtPurposeDes = new System.Windows.Forms.TextBox();
            this.cBDuration = new System.Windows.Forms.ComboBox();
            this.btnBook = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnPreFill = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.lblPostalError = new System.Windows.Forms.Label();
            this.txtPostalCode = new System.Windows.Forms.TextBox();
            this.lblEmailError = new System.Windows.Forms.Label();
            this.lblPhoneNumError = new System.Windows.Forms.Label();
            this.lblAgeError = new System.Windows.Forms.Label();
            this.lblErrorName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(49, 58);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(157, 23);
            this.txtName.TabIndex = 0;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(49, 173);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(157, 23);
            this.txtAddress.TabIndex = 0;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(49, 227);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(157, 23);
            this.txtCity.TabIndex = 0;
            // 
            // txtProvince
            // 
            this.txtProvince.Location = new System.Drawing.Point(49, 286);
            this.txtProvince.Name = "txtProvince";
            this.txtProvince.Size = new System.Drawing.Size(157, 23);
            this.txtProvince.TabIndex = 0;
            // 
            // txtPhoneNum
            // 
            this.txtPhoneNum.Location = new System.Drawing.Point(49, 411);
            this.txtPhoneNum.Name = "txtPhoneNum";
            this.txtPhoneNum.Size = new System.Drawing.Size(157, 23);
            this.txtPhoneNum.TabIndex = 0;
            this.txtPhoneNum.TextChanged += new System.EventHandler(this.txtPhoneNum_TextChanged);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(49, 470);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(157, 23);
            this.txtEmail.TabIndex = 0;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // lblPatientName
            // 
            this.lblPatientName.AutoSize = true;
            this.lblPatientName.Location = new System.Drawing.Point(51, 40);
            this.lblPatientName.Name = "lblPatientName";
            this.lblPatientName.Size = new System.Drawing.Size(79, 15);
            this.lblPatientName.TabIndex = 1;
            this.lblPatientName.Text = "Patient Name";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(57, 155);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(49, 15);
            this.lblAddress.TabIndex = 1;
            this.lblAddress.Text = "Address";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(57, 209);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(28, 15);
            this.lblCity.TabIndex = 1;
            this.lblCity.Text = "City";
            // 
            // lblProvince
            // 
            this.lblProvince.AutoSize = true;
            this.lblProvince.Location = new System.Drawing.Point(57, 268);
            this.lblProvince.Name = "lblProvince";
            this.lblProvince.Size = new System.Drawing.Size(53, 15);
            this.lblProvince.TabIndex = 1;
            this.lblProvince.Text = "Province";
            // 
            // lblPostalCode
            // 
            this.lblPostalCode.AutoSize = true;
            this.lblPostalCode.Location = new System.Drawing.Point(57, 326);
            this.lblPostalCode.Name = "lblPostalCode";
            this.lblPostalCode.Size = new System.Drawing.Size(70, 15);
            this.lblPostalCode.TabIndex = 1;
            this.lblPostalCode.Text = "Postal Code";
            // 
            // lblPhoneNum
            // 
            this.lblPhoneNum.AutoSize = true;
            this.lblPhoneNum.Location = new System.Drawing.Point(57, 393);
            this.lblPhoneNum.Name = "lblPhoneNum";
            this.lblPhoneNum.Size = new System.Drawing.Size(88, 15);
            this.lblPhoneNum.TabIndex = 1;
            this.lblPhoneNum.Text = "Phone Number";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(57, 452);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(36, 15);
            this.lblEmail.TabIndex = 1;
            this.lblEmail.Text = "Email";
            // 
            // lblBirthDate
            // 
            this.lblBirthDate.AutoSize = true;
            this.lblBirthDate.Location = new System.Drawing.Point(57, 96);
            this.lblBirthDate.Name = "lblBirthDate";
            this.lblBirthDate.Size = new System.Drawing.Size(73, 15);
            this.lblBirthDate.TabIndex = 2;
            this.lblBirthDate.Text = "Date of Birth";
            // 
            // dateTimeBirth
            // 
            this.dateTimeBirth.Location = new System.Drawing.Point(49, 114);
            this.dateTimeBirth.Name = "dateTimeBirth";
            this.dateTimeBirth.Size = new System.Drawing.Size(157, 23);
            this.dateTimeBirth.TabIndex = 3;
            this.dateTimeBirth.ValueChanged += new System.EventHandler(this.dateTimeBirth_ValueChanged);
            // 
            // dateTimeAppTime
            // 
            this.dateTimeAppTime.CustomFormat = "MM/dd/yyyy hh:mm:ss";
            this.dateTimeAppTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeAppTime.Location = new System.Drawing.Point(439, 79);
            this.dateTimeAppTime.Name = "dateTimeAppTime";
            this.dateTimeAppTime.Size = new System.Drawing.Size(220, 23);
            this.dateTimeAppTime.TabIndex = 4;
            // 
            // lblReqAppTime
            // 
            this.lblReqAppTime.AutoSize = true;
            this.lblReqAppTime.Location = new System.Drawing.Point(439, 58);
            this.lblReqAppTime.Name = "lblReqAppTime";
            this.lblReqAppTime.Size = new System.Drawing.Size(165, 15);
            this.lblReqAppTime.TabIndex = 5;
            this.lblReqAppTime.Text = "Requested Appointment Time";
            // 
            // lblAppDur
            // 
            this.lblAppDur.AutoSize = true;
            this.lblAppDur.Location = new System.Drawing.Point(439, 122);
            this.lblAppDur.Name = "lblAppDur";
            this.lblAppDur.Size = new System.Drawing.Size(127, 15);
            this.lblAppDur.TabIndex = 5;
            this.lblAppDur.Text = "Appointment Duration";
            // 
            // lblPurpose
            // 
            this.lblPurpose.AutoSize = true;
            this.lblPurpose.Location = new System.Drawing.Point(439, 195);
            this.lblPurpose.Name = "lblPurpose";
            this.lblPurpose.Size = new System.Drawing.Size(138, 15);
            this.lblPurpose.TabIndex = 5;
            this.lblPurpose.Text = "Purpose of Appointment";
            // 
            // txtPurposeDes
            // 
            this.txtPurposeDes.Location = new System.Drawing.Point(439, 239);
            this.txtPurposeDes.Name = "txtPurposeDes";
            this.txtPurposeDes.Size = new System.Drawing.Size(0, 23);
            this.txtPurposeDes.TabIndex = 6;
            // 
            // cBDuration
            // 
            this.cBDuration.FormattingEnabled = true;
            this.cBDuration.Items.AddRange(new object[] {
            "15 minutes",
            "30 minutes",
            "45 minutes",
            "1 hour"});
            this.cBDuration.Location = new System.Drawing.Point(439, 147);
            this.cBDuration.Name = "cBDuration";
            this.cBDuration.Size = new System.Drawing.Size(190, 23);
            this.cBDuration.TabIndex = 7;
            // 
            // btnBook
            // 
            this.btnBook.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnBook.Location = new System.Drawing.Point(439, 344);
            this.btnBook.Name = "btnBook";
            this.btnBook.Size = new System.Drawing.Size(98, 23);
            this.btnBook.TabIndex = 8;
            this.btnBook.Text = "Book";
            this.btnBook.UseVisualStyleBackColor = false;
            this.btnBook.Click += new System.EventHandler(this.btnBook_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnReset.Location = new System.Drawing.Point(578, 344);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(98, 23);
            this.btnReset.TabIndex = 8;
            this.btnReset.Text = "Reset Fields";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnPreFill
            // 
            this.btnPreFill.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnPreFill.Location = new System.Drawing.Point(439, 385);
            this.btnPreFill.Name = "btnPreFill";
            this.btnPreFill.Size = new System.Drawing.Size(98, 23);
            this.btnPreFill.TabIndex = 8;
            this.btnPreFill.Text = "Pre-Fill Fields";
            this.btnPreFill.UseVisualStyleBackColor = false;
            this.btnPreFill.Click += new System.EventHandler(this.btnPreFill_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnPrint.Location = new System.Drawing.Point(578, 385);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(98, 23);
            this.btnPrint.TabIndex = 8;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(439, 213);
            this.txtDesc.Multiline = true;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(195, 96);
            this.txtDesc.TabIndex = 9;
            // 
            // lblPostalError
            // 
            this.lblPostalError.AutoSize = true;
            this.lblPostalError.BackColor = System.Drawing.SystemColors.Control;
            this.lblPostalError.ForeColor = System.Drawing.Color.Red;
            this.lblPostalError.Location = new System.Drawing.Point(439, 487);
            this.lblPostalError.Name = "lblPostalError";
            this.lblPostalError.Size = new System.Drawing.Size(282, 15);
            this.lblPostalError.TabIndex = 10;
            this.lblPostalError.Text = "Postal Code must be in a valid format (e.g NCB 1C5)";
            this.lblPostalError.TextChanged += new System.EventHandler(this.txtPostalCode_TextChanged);
            // 
            // txtPostalCode
            // 
            this.txtPostalCode.Location = new System.Drawing.Point(49, 357);
            this.txtPostalCode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPostalCode.Name = "txtPostalCode";
            this.txtPostalCode.Size = new System.Drawing.Size(157, 23);
            this.txtPostalCode.TabIndex = 11;
            this.txtPostalCode.TextChanged += new System.EventHandler(this.txtPostalCode_TextChanged);
            // 
            // lblEmailError
            // 
            this.lblEmailError.AutoSize = true;
            this.lblEmailError.BackColor = System.Drawing.SystemColors.Control;
            this.lblEmailError.ForeColor = System.Drawing.Color.Red;
            this.lblEmailError.Location = new System.Drawing.Point(438, 461);
            this.lblEmailError.Name = "lblEmailError";
            this.lblEmailError.Size = new System.Drawing.Size(221, 15);
            this.lblEmailError.TabIndex = 10;
            this.lblEmailError.Text = "Email must be provided in a valid format";
            // 
            // lblPhoneNumError
            // 
            this.lblPhoneNumError.AutoSize = true;
            this.lblPhoneNumError.BackColor = System.Drawing.SystemColors.Control;
            this.lblPhoneNumError.ForeColor = System.Drawing.Color.Red;
            this.lblPhoneNumError.Location = new System.Drawing.Point(439, 516);
            this.lblPhoneNumError.Name = "lblPhoneNumError";
            this.lblPhoneNumError.Size = new System.Drawing.Size(297, 15);
            this.lblPhoneNumError.TabIndex = 10;
            this.lblPhoneNumError.Text = "Phone number ust be in a valid format(e.g 1234567890)";
            // 
            // lblAgeError
            // 
            this.lblAgeError.AutoSize = true;
            this.lblAgeError.BackColor = System.Drawing.SystemColors.Control;
            this.lblAgeError.ForeColor = System.Drawing.Color.Red;
            this.lblAgeError.Location = new System.Drawing.Point(439, 547);
            this.lblAgeError.Name = "lblAgeError";
            this.lblAgeError.Size = new System.Drawing.Size(211, 15);
            this.lblAgeError.TabIndex = 10;
            this.lblAgeError.Text = "Patient must be at least 18 years of age";
            this.lblAgeError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblErrorName
            // 
            this.lblErrorName.AutoSize = true;
            this.lblErrorName.BackColor = System.Drawing.SystemColors.Control;
            this.lblErrorName.ForeColor = System.Drawing.Color.Red;
            this.lblErrorName.Location = new System.Drawing.Point(439, 428);
            this.lblErrorName.Name = "lblErrorName";
            this.lblErrorName.Size = new System.Drawing.Size(161, 15);
            this.lblErrorName.TabIndex = 10;
            this.lblErrorName.Text = "First AND Last name required";
            this.lblErrorName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.txtPostalCode);
            this.Controls.Add(this.lblEmailError);
            this.Controls.Add(this.lblErrorName);
            this.Controls.Add(this.lblAgeError);
            this.Controls.Add(this.lblPhoneNumError);
            this.Controls.Add(this.lblPostalError);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnPreFill);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnBook);
            this.Controls.Add(this.cBDuration);
            this.Controls.Add(this.txtPurposeDes);
            this.Controls.Add(this.lblPurpose);
            this.Controls.Add(this.lblAppDur);
            this.Controls.Add(this.lblReqAppTime);
            this.Controls.Add(this.dateTimeAppTime);
            this.Controls.Add(this.dateTimeBirth);
            this.Controls.Add(this.lblBirthDate);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblPhoneNum);
            this.Controls.Add(this.lblPostalCode);
            this.Controls.Add(this.lblProvince);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblPatientName);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtPhoneNum);
            this.Controls.Add(this.txtProvince);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtName;
        private TextBox txtAddress;
        private TextBox txtCity;
        private TextBox txtProvince;

        //private TextBox txtPostalCode;

        private TextBox txtPhoneNum;
        private TextBox txtEmail;
        private Label lblPatientName;
        private Label lblAddress;
        private Label lblCity;
        private Label lblProvince;
        private Label lblPostalCode;
        private Label lblPhoneNum;
        private Label lblEmail;
        private Label lblBirthDate;
        private DateTimePicker dateTimeBirth;
        private DateTimePicker dateTimeAppTime;
        private Label lblReqAppTime;
        private Label lblAppDur;
        private Label lblPurpose;
        private TextBox txtPurposeDes;
        private ComboBox cBDuration;
        private Button btnBook;
        private Button btnReset;
        private Button btnPreFill;
        private Button btnPrint;
        private TextBox txtDesc;
        private Label lblPostalError;
        private TextBox txtPostalCode;
        private Label lblEmailError;
        private Label lblPhoneNumError;
        private Label lblAgeError;
        private Label lblErrorName;
    }
}