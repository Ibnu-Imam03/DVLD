using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVLD.Login;
using DVLD_BusinessLayer;
namespace DVLD
{
    public partial class frmMain : Form
    {
        frmLogin _frmLogin;
        public frmMain(frmLogin frm)
        {
            InitializeComponent();
            _frmLogin = frm;
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

      
    }
}
