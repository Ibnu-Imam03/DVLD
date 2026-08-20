using DVLD_BusinessLayer;
using System;
using System.Windows.Forms;

namespace DVLD
{
    public partial class UpdatePeople : Form
    {
        private int _ID = -1;

        public UpdatePeople(int PersonID)
        {
            InitializeComponent();
            _ID = PersonID;
        }

        clsPeople Person;

        private void UpdatePeople_Load(object sender, EventArgs e)
        {
            Person = usPersonInfo1.UpdatePersonData(_ID);

            if (Person == null)
            {
                MessageBox.Show("Person not found.");
                this.Close();
                return;
            }

            txtPersonID.Text = Person.PersonID.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Person = usPersonInfo1.LoadPersonData();

            if (Person == null)
            {
                return;
            }

            if (Person.Save())
            {
                MessageBox.Show("Person updated successfully.");
            }
            else
            {
                MessageBox.Show("Failed to update person.");
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void usPersonInfo1_Load(object sender, EventArgs e)
        {

        }
    }
}