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


        public int LoadData(int PersonID)
        {
            clsPeople Person = new clsPeople();

            if (PersonID ==-1)
            {
                Person.FirstName = txtFirstName.Text;
                Person.SecondName = txtSecoundName.Text;
                Person.ThirdName = txtThirdName.Text;
                Person.LastName = txtLastName.Text;
                Person.NationalNo = txtNationalID.Text;
                if (rbMale.Checked)
                {
                    Person.Gendor = 0;
                }
                else
                {
                    Person.Gendor = 1;
                }
                Person.Email = txtEmail.Text;
                Person.Phone = txtPhone.Text;
                Person.DateOfBirth = dtpDateOfBirth.Value;
                Person.NationalityCountryID = cbCountries.SelectedIndex;
                Person.Address = txtAddress.Text;
                Person.ImagePath = _ImagePath;
                if (Person.Save())
                {
                    return Person.PersonID;
                }

                return -1;

            }

            else if (Person.Find(PersonID))
            {
                txtFirstName.Text = Person.FirstName;
                txtFirstName.Enabled = false;
                txtSecoundName.Text = Person.SecondName;
                txtSecoundName.Enabled = false;
                txtThirdName.Text = Person.ThirdName;
                txtThirdName.Enabled = false;
                txtLastName.Text = Person.LastName;
                txtLastName.Enabled = false;
                txtAddress.Text = Person.Address;
                txtAddress.Enabled = false;
                txtEmail.Text = Person.Email;
                txtEmail.Enabled = false;
                txtNationalID.Text = Person.NationalNo;
                txtNationalID.Enabled = false;
                txtPhone.Text = Person.Phone;
                txtNationalID.Enabled = false;
                cbCountries.SelectedIndex = Person.NationalityCountryID;
                cbCountries.Enabled = false;
                if (Person.Gendor == 0)
                {
                    rbMale.Checked = true;
                    rbMale.Enabled = false;
                }
                else
                {
                    rbFemale.Checked = true;
                    rbFemale.Enabled = false;
                }
                if (Person.ImagePath != "")
                {
                    pictureBox1.ImageLocation = Person.ImagePath;
                    llRemoveImage.Visible = false;
                    llSaveImage.Visible = false;

                }
                return Person.PersonID;
            }

            else
            {
                MessageBox.Show("No Person Data");
                return -1;
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

        private void btnSave_Click(object sender, System.EventArgs e)
        {
            
        }

        private void btnCancel_Click(object sender, System.EventArgs e)
        {
            this.FindForm().Close();

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

        public  clsPeople GetPerson()
        {
            return Person;
        }
        public  int GetPersonID()
        {
            return Person.PersonID;
        }
    }
}
