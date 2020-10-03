using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Farbmanagement
{
    public partial class Farbenmanagement : Form
    {
        public Farbenmanagement()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        public void btnSelectGroundColor_Click(object sender, EventArgs e)
        {
            SqlColorConnection DatabaseConnectionLH = new SqlColorConnection();
            DatabaseConnectionLH.GetLackierStufen();
        }
    }
}
