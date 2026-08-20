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

        private void ManagePeople_Load(object sender, EventArgs e)
        {
            dgvManage_People.DataSource = clsPeople.GetAllPeoeple();

            cbFilter.Items.Add("None");
            cbFilter.Items.Add("PersonID");
            cbFilter.Items.Add("NationalNo");
            cbFilter.Items.Add("FirstName");
            cbFilter.Items.Add("SecondName");
            cbFilter.Items.Add("ThirdName");
            cbFilter.Items.Add("LastName");
            cbFilter.Items.Add("CountryName");
            cbFilter.Items.Add("Gendor");
            cbFilter.Items.Add("Phone");
            cbFilter.Items.Add("Email");

            cbFilter.SelectedIndex = 0;
            lblTotal.Text = clsPeople.GetAllPeoeple().Rows.Count.ToString();


        }
             
        private void txtFilter_TextChanged(object sender, EventArgs e)
        {

            if (cbFilter.SelectedItem.ToString() == "None" || txtFilter.Text == "")
            {
                dgvManage_People.DataSource = clsPeople.GetAllPeoeple();

            }
            else if (cbFilter.SelectedItem.ToString() == "PersonID")
            {
                dgvManage_People.DataSource = clsPeople.GetPerson(cbFilter.SelectedItem.ToString(), int.Parse(txtFilter.Text));

            }
            else
            {
                dgvManage_People.DataSource = clsPeople.GetPerson(cbFilter.SelectedItem.ToString(), txtFilter.Text);

            }

        }

        
        private void PersonAdd_Click(object sender, EventArgs e)
        {
            Add_EditForm frm = new Add_EditForm();
            frm.Show();
        }

       

        private void addNewPersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Add_EditForm frm = new Add_EditForm();
            frm.Show();
        }

        private void showDetailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            ViewDetails frm = new ViewDetails(1);
            frm.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
    
