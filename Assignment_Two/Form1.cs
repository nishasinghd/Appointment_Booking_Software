using System.Text.RegularExpressions;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Assignment_Two
{
    public partial class Form1 : Form
    {
        Office office = new Office();
        public Form1()
        {
            InitializeComponent();            
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            ClearUserInputs();
            //LabelErrors();
        }     

        private void btnBook_Click(object sender, EventArgs e)
        {
            dateTimeAppTime.CalendarMonthBackground = SystemColors.Window;
            string address = txtAddress.Text;
            string city = txtCity.Text;
            string province = txtProvince.Text;
            string name = txtName.Text;
            string postalCode = txtPostalCode.Text;
            string phoneNum = txtPhoneNum.Text;
            string email = txtEmail.Text;
            DateTime birthDate = dateTimeBirth.Value;
            int age = DateTime.Today.Year - birthDate.Year;
            DateTime reqAppTime = dateTimeAppTime.Value;
            string appDurationS = cBDuration.Text;
            string[] appDuration = appDurationS.Split(" ");
            int appSpan = int.Parse(appDuration[0]);
            string appDesc = txtDesc.Text;

            if (appDurationS == "1 hour" ) 
            {
                appSpan = 60;
            }

            if ((ValidationHelper.IsValidName(name)) 
                && (ValidationHelper.IsEmailValid(email)) 
                && (ValidationHelper.IsValidPatientAge(birthDate)) 
                && ((ValidationHelper.IsPostalCodeValid(postalCode))
                && (ValidationHelper.IsValidPhoneNumber(phoneNum))
                && (!string.IsNullOrEmpty(address))
                && (!string.IsNullOrEmpty(city))
                && (!string.IsNullOrEmpty(province))))
            {             
                if (office.BookAppointment(reqAppTime, appSpan))
                {
                    Appointment appointment = new Appointment(name, age, email, phoneNum, postalCode, address, city, province, reqAppTime, appSpan, appDesc);
                    office.AddAppointment(appointment);

                    MessageBox.Show("Successfully booked your appointment on " + reqAppTime , "Successful");
                    ClearUserInputs();
                    LabelErrors();
                }
                else if (!office.BookAppointment(reqAppTime, appSpan))
                {
                    MessageBox.Show("That appointment time conflicts with another patient. Please select a different time", "Unsuccessful");
                    dateTimeAppTime.CalendarMonthBackground = Color.Coral;
                }
            }
            else
            {
                if (string.IsNullOrEmpty(address))
                {
                    txtAddress.Text = "Enter Address";
                    txtAddress.BackColor = Color.Yellow;
                }
                if (string.IsNullOrEmpty(city))
                {
                    txtCity.Text = "Enter City";
                    txtCity.BackColor = Color.Yellow;
                }
                if (string.IsNullOrEmpty(province))
                {
                    txtProvince.Text = "Enter Province";
                    txtProvince.BackColor = Color.Yellow;
                }
                else
                {
                    LabelErrors();
                    MessageBox.Show("You have entered invalid input for one of the text fields.Check to see which error message is still showing", "Invalid Input");
                }
                
            }
        }
        private void ClearUserInputs()
        {
            txtAddress.Clear();
            txtCity.Clear();
            txtProvince.Clear();
            txtName.Clear();
            txtPostalCode.Clear();
            txtPhoneNum.Clear();
            txtEmail.Clear();
            dateTimeBirth.Value = DateTime.Today;
            cBDuration.SelectedIndex = -1;
            txtDesc.Clear();
            dateTimeAppTime.CalendarMonthBackground = SystemColors.Window;
            txtProvince.BackColor= SystemColors.Window;
            txtCity.BackColor= SystemColors.Window;
            txtAddress.BackColor= SystemColors.Window;
        }
        private void txtPostalCode_TextChanged(object sender, EventArgs e)
        {
            string postalCode = txtPostalCode.Text;
            bool isValid = ValidationHelper.IsPostalCodeValid(postalCode);
            if (isValid)
            {
                lblPostalError.Text = null;
            }
        }
        private void txtPhoneNum_TextChanged(object sender, EventArgs e)
        {
            
            string phoneNum = txtPhoneNum.Text;
            bool isValid = ValidationHelper.IsValidPhoneNumber(phoneNum);
            if (isValid)
            {                
                lblPhoneNumError.Text = null;
            }
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            bool isValid = ValidationHelper.IsEmailValid(email);
            if (isValid)
            {
                lblEmailError.Text = null;
            }
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {            
            string name = txtName.Text;
            bool isValid = ValidationHelper.IsValidName(name);
            if (isValid)
            {
                lblErrorName.Text = null;
            }             
        }

        private void dateTimeBirth_ValueChanged(object sender, EventArgs e)
        {
            DateTime dateOfBirth = dateTimeBirth.Value;
            bool isValid = ValidationHelper.IsValidPatientAge(dateOfBirth);
            if (isValid)
            {
                lblAgeError.Text = null;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ClearUserInputs();
            LabelErrors();
        }

        private void btnPreFill_Click(object sender, EventArgs e)
        {
            txtAddress.Text = "123 Albert street";
            txtCity.Text = "Toronto";
            txtProvince.Text = "ON";
            txtName.Text = "John Doe";
            txtPostalCode.Text = "A1B 2C3";
            txtPhoneNum.Text = "1234567890";
            txtEmail.Text = "johndoe@gmail.com";
            DateTime currentDate = DateTime.Now;
            dateTimeBirth.Value = new DateTime(2000, currentDate.Month, currentDate.Day);
            cBDuration.SelectedIndex = 0;
            txtDesc.Text = "General check-up";
        }

        public void LabelErrors()
        {
            cBDuration.SelectedIndex = 0;
            string name = txtName.Text;
            string postalCode = txtPostalCode.Text;
            string phoneNum = txtPhoneNum.Text;
            string email = txtEmail.Text;
            DateTime birthDate = dateTimeBirth.Value;
            int age = DateTime.Today.Year - birthDate.Year;
            DateTime reqAppTime = dateTimeAppTime.Value;
            string appDurationS = cBDuration.Text;
            string[] appDuration = appDurationS.Split(" ");
            int appSpan = int.Parse(appDuration[0]);
            string appDesc = txtDesc.Text;

            if (!ValidationHelper.IsValidName(name))
                lblErrorName.Text = "First AND Last name required";
            if(!(ValidationHelper.IsValidPatientAge(birthDate)))
                lblAgeError.Text += "Patient must be at least 18 years of age";
            if (!(ValidationHelper.IsEmailValid(email)))
                lblEmailError.Text = "Email must be provided in a valid format";
             if (!(ValidationHelper.IsPostalCodeValid(postalCode)))
                lblPostalError.Text = "Postal Code must be in a valid format (e.g NCB 1C5)";
            if (!(ValidationHelper.IsValidPhoneNumber(phoneNum)))
                lblPhoneNumError.Text = "Phone number ust be in a valid format(e.g 1234567890)";               
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            office.PrintApp();
        }
    }
}