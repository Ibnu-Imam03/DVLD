using System.Windows.Forms;

using DVLD_BusinessLayer;

namespace DVLD
{
    public partial class usPersonInfo : UserControl
    {
        public usPersonInfo()
        {
            InitializeComponent();
        }

        private void usPersonInfo_Load(object sender, System.EventArgs e)
        {
            cbCountries.DataSource = Countries.GetAllCountries();
            cbCountries.DisplayMember = "CountryName";

            rbMale.Checked = true;

            if (rbMale.Checked)
            {
                pictureBox1.Image = imageList1.Images[0];
            }

        }

        private bool _ISValid(string Name)
        {
            foreach (char c in Name)
            {
                if (!char.IsLetter(c) && !char.IsWhiteSpace(c))
                {
                   
                    return false;
                }
            }

            

           return true;

        }


        private void txtFirstName_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {

           
            if (txtFirstName.Text == "")
            {
                e.Cancel = true;
                errorProvider1.SetError(txtFirstName, "First Name is required");
            }
            else if (_ISValid(txtFirstName.Text))
            {
                e.Cancel = false;
                errorProvider1.SetError(txtFirstName, "");
            }
            else
            {
                e.Cancel = true;
                errorProvider1.SetError(txtFirstName, "Please enter letters only");
            }
                                                 

        }

        private void txtSecoundName_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            
            if (txtSecoundName.Text == "")
            {
                e.Cancel = true;
                errorProvider1.SetError(txtSecoundName, "Secound Name is required");
            }
            else if (_ISValid(txtSecoundName.Text))
            {
                e.Cancel = false;
                errorProvider1.SetError(txtSecoundName, "");
            }
            else
            {
                e.Cancel = true;
                errorProvider1.SetError(txtSecoundName, "Please enter letters only");
            }
        }

        private void txtThirdName_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            
            if (txtThirdName.Text == "")
            {
                e.Cancel = true;
                errorProvider1.SetError(txtThirdName, "Third Name is required");
            }
            else if (_ISValid(txtThirdName.Text))
            {
                e.Cancel = false;
                errorProvider1.SetError(txtThirdName, "");
            }
            else
            {
                e.Cancel = true;
                errorProvider1.SetError(txtThirdName, "Please enter letters only");
            }
        }

        private void txtLastName_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            
            if (txtLastName.Text == "")
            {
                e.Cancel = true;
                errorProvider1.SetError(txtLastName, "Last Name is required");
            }
            else if (_ISValid(txtLastName.Text))
            {
                e.Cancel = false;
                errorProvider1.SetError(txtLastName, "");
            }
            else
            {
                e.Cancel = true;
                errorProvider1.SetError(txtLastName, "Please enter letters only");
            }
        }

        private void txtNationalID_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (txtNationalID.Text =="")
            {
                e.Cancel = true;
                errorProvider1.SetError(txtNationalID, "Please enter UniqueNational Number ");
            }
            else if (clsPeople.IsNationalIDExist(txtNationalID.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtNationalID, "National Number already exists.");
            }
            else
            {

                e.Cancel = false;
                errorProvider1.SetError(txtNationalID, "");
            }
        }

        private void txtAddress_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (txtAddress.Text == "")
            {
                e.Cancel = true;
                errorProvider1.SetError(txtAddress, "Please enter An Address");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtAddress, "");
            }
        }

        private void txtPhone_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {

            if (txtPhone.Text == "")
            {
                e.Cancel = true;
                errorProvider1.SetError(txtPhone, "Please enter a Phone Number");
                return;
            }

            foreach (char c in txtPhone.Text)
            {
                    if (!char.IsDigit(c))
                    {
                        e.Cancel = true;
                        errorProvider1.SetError(txtPhone, "Invalid phone number ");
                        return;
                    }
            }

            e.Cancel = false;
            errorProvider1.SetError(txtPhone, "");

        }

        private void txtEmail_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if ( txtEmail.Text.EndsWith("@gmail.com") || txtEmail.Text == "")
            {
                e.Cancel = false;
                errorProvider1.SetError(txtEmail, "");
            }
            else
            {
                e.Cancel = true;
                errorProvider1.SetError(txtEmail, "Please enter a valid email address.");
            }

        }

        private void rbMale_CheckedChanged(object sender, System.EventArgs e)
        {
            if (rbMale.Checked)
            {
                pictureBox1.Image = imageList1.Images[0];
            }
        }

        private void rbFemale_CheckedChanged(object sender, System.EventArgs e)
        {
            if (rbFemale.Checked)
            {
                pictureBox1.Image = imageList1.Images[1];
            }
        }

        private void btnSave_Click(object sender, System.EventArgs e)
        {
            clsPeople Person = new clsPeople();
            Person.FirstName = txtFirstName.Text;
            Person.SecondName = txtSecoundName.Text;
            Person.ThirdName = txtThirdName.Text;
            Person.LastName = txtLastName.Text;
            Person.NationalNo = txtNationalID.Text;
            if (rbMale.Checked)
            {
                Person.Gendor = "Male";
            }
            else
            {
                Person.Gendor = "Female";
            }

            Person.Email = txtEmail.Text;
            Person.Phone = txtPhone.Text;
            Person.DateOfBirth = dtpDateOfBirth.Value;
            Person.NationalityCountryID = cbCountries.SelectedIndex;
            Person.Address = txtAddress.Text;
            Person.ImagePath = "";

            Person.Save();
        }
    }
}
