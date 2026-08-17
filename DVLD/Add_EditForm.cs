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
        public delegate void DataEventHandeler(object sender, clsPeople People);
        public event DataEventHandeler DataBack;
        clsPeople Person {  get; set; }

        private void Add_EditForm_Load(object sender, EventArgs e)
        {

        }

        private void usPersonInfo1_Load(object sender, EventArgs e)
        {

        }

       
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            clsPeople Person = new clsPeople();
            Person = usPersonInfo1.LoadPersonData();
            lblPersonID.Text = Person.PersonID.ToString();
            Person.Save();


        }
    }
}
