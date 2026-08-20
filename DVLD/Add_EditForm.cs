using DVLD_BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD
{
    public partial class Add_EditForm : Form
    {
        public Add_EditForm()
        {
            InitializeComponent();
        }
        public delegate void DataEventHandeler(object sender);
        public event DataEventHandeler DataBack;

       
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            clsPeople Person = new clsPeople();
            Person = usPersonInfo1.LoadPersonData();
            if (Person == null)
            {
                lblPersonID.Text = "-1";
                return;
            }
            Person.Save();
            lblPersonID.Text = Person.PersonID.ToString();

            DataBack?.Invoke(this);

        }

        private void Add_EditForm_Load(object sender, EventArgs e)
        {

        }
    }
}
