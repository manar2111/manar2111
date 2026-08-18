using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private bool _UserNAME()
        {
            string User = "Ahamd";
            string password = "12345";

            if (TBUser.Text == User && tbPassword.Text == password)
            {
                return true;
            }
            else
            {

                return false;
            }


        }
        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            if (_UserNAME() == true)
            {
                frmListContacts frmData = new frmListContacts();
                frmData.ShowDialog();

            }
            else
            {
                MessageBox.Show("This is not Correct Try again", MessageBoxButtons.OK.ToString()).ToString();
            }
        }

        private void TBUser_TextChanged(object sender, EventArgs e)
        {
            _UserNAME();
        }


    }
}
