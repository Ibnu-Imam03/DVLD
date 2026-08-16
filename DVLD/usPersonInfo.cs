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
    }
}
