using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVLD_BusinessLayer;
namespace DVLD.Login
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void UserName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUserName.Text))
            {
                errorProvider1.SetError(txtUserName, "Please enter a username.");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txtUserName, string.Empty);
                e.Cancel = false;
            }
        }

        private void Password_Validating(object sender, CancelEventArgs e)
        {


            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtPassword, "Password is required.");
                return;
            }
            else
            {
                errorProvider1.SetError(txtPassword, string.Empty);
                e.Cancel = false;
            }

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Fill The Field is required !!", "ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }

            if (clsUser.IsExisted(txtUserName.Text, txtPassword.Text))
            {
                if (clsUser.IsActive(txtUserName.Text))
                {
                    PeopleManagment frm = new PeopleManagment();
                    frm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Your account is inactive.",
                        "Login Failed",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Invalid username or password.",
                    "Login Failed",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
           
        }
    }
}
