using System;
using System.Data;
using System.Windows.Forms;
using DVLD_BusinessLayer;
namespace DVLD
{
    public partial class ManagePeople : Form
    {
        public ManagePeople()
        {
            InitializeComponent();
        }

       

        private void userPeopleList1_Load(object sender, EventArgs e)
        {

        }

        private void ManagePeople_Load(object sender, EventArgs e)
        {
            dgvManage_People.DataSource = clsPeople.GetAllPeoeple();
        }

       
    }
}
