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
namespace DVLD
{
    public partial class PeopleManagment : Form
    {
        public PeopleManagment()
        {
            InitializeComponent();
        }

       

        private void PeopleManagment_Load(object sender, EventArgs e)
        {

        }

        private void btnApplication_Click(object sender, EventArgs e)
        {

        }

        private void btnPeople_Click(object sender, EventArgs e)
        {
            Form ManagePeople = new ManagePeople();
            ManagePeople.Show();
        }

        private void btnDriver_Click(object sender, EventArgs e)
        {
            ViewDetails frm = new ViewDetails(1);
            frm.Show();
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {

        }

        private void btnAccountSettings_Click(object sender, EventArgs e)
        {

        }
    }
}
