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
    public partial class ViewDetails : Form
    {
        private int _PersonID = -1;
        public ViewDetails(int ID )
        {
            InitializeComponent();
            _PersonID = ID;
        }

        private void usPersonInfo1_Load(object sender, EventArgs e)
        {
            
        }

        private void ViewDetails_Load(object sender, EventArgs e)
        {
            lblPersonID.Text = _PersonID.ToString();

        }
    }
}
