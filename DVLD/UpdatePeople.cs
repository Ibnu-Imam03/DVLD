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
    public partial class UpdatePeople : Form
    {
        private int _ID = -1;
        public UpdatePeople(int PersonID)
        {
            InitializeComponent();
            _ID= PersonID;
        }
        clsPeople Person = new clsPeople();
        private void UpdatePeople_Load(object sender, EventArgs e)
        {
            clsPeople Person = usPersonInfo1.UpdatePersonData(_ID);
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Person = usPersonInfo1.LoadPersonData();
            if (Person == null)
            {
                return;
            }
            Person.Save();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
