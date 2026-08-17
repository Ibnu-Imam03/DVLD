using DVLD_BusinessLayer;
using System;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace DVLD
{
    public partial class usPersonInfo : UserControl
    {
       
        public usPersonInfo()
        {
            InitializeComponent();
            
        }
     
        private string _ImagePath = "";
        private clsPeople Person = new clsPeople();

        public delegate void DataEventHandeler(object sender, DataTable People);
        public event DataEventHandeler DataBack;


        public clsPeople LoadPersonData()
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Please correct the validation errors.");
                return null;
            }
            else
            {
                Person.FirstName = txtFirstName.Text;
                Person.SecondName = txtSecoundName.Text;
                Person.ThirdName = txtThirdName.Text;
                Person.LastName = txtLastName.Text;
                Person.NationalNo = txtNationalID.Text;

                Person.Gendor = rbMale.Checked ? 0 : 1;

                Person.Email = txtEmail.Text;
                Person.Phone = txtPhone.Text;
                Person.DateOfBirth = dtpDateOfBirth.Value;
                Person.NationalityCountryID = cbCountries.SelectedIndex;
                Person.Address = txtAddress.Text;
                Person.ImagePath = _ImagePath;
                return Person;
            }
            
           
        }
        public void LoadData(int PersonID)
        {
            clsPeople person = new clsPeople();
            if (person.Find(PersonID) == null)
            {
                MessageBox.Show("WWWWWWWffffffffffffffffffffffWWWW");
            }
            else
            {


                txtFirstName.Text = Person.FirstName;
                txtFirstName.ReadOnly = true;

                txtSecoundName.Text = Person.SecondName;
                txtSecoundName.ReadOnly = true;

                txtThirdName.Text = Person.ThirdName;
                txtThirdName.ReadOnly = true;

                txtLastName.Text = Person.LastName;
                txtLastName.ReadOnly = true;

                txtNationalID.Text = Person.NationalNo;
                txtNationalID.ReadOnly = true;

                txtPhone.Text = Person.Phone;
                txtPhone.ReadOnly = true;

                txtEmail.Text = Person.Email;
                txtEmail.ReadOnly = true;

                txtAddress.Text = Person.Address;
                txtAddress.ReadOnly = true;

                // Country
                cbCountries.SelectedValue = Person.NationalityCountryID;
                cbCountries.Enabled = false;

                // Gender
                if (Person.Gendor == 0)
                {
                    rbMale.Checked = true;
                }
                else
                {
                    rbFemale.Checked = true;
                }

                rbMale.Enabled = false;
                rbFemale.Enabled = false;

                // Image
                if (!string.IsNullOrEmpty(Person.ImagePath))
                {
                    pictureBox1.ImageLocation = Person.ImagePath;
                }

                // Hide image options
                llRemoveImage.Visible = false;
                llSaveImage.Visible = false;
            }
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

            llRemoveImage.Visible = false;
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

           

        private void llSaveImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
        {
                string ImagesFolder = @"C:\DVLD Images";

                if (!Directory.Exists(ImagesFolder))
            {   
                Directory.CreateDirectory(ImagesFolder);
            }
            string FileName = Guid.NewGuid().ToString() + Path.GetExtension(openFileDialog.FileName);
            _ImagePath = Path.Combine(ImagesFolder, FileName);
            File.Copy(openFileDialog.FileName, _ImagePath);

            pictureBox1.ImageLocation = _ImagePath;

        }

            llRemoveImage.Visible = true;

        }

        private void llRemoveImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pictureBox1.Image = imageList1.Images[0];
            llRemoveImage.Visible = false;
            _ImagePath = "";
        }

       

       
    }
}
