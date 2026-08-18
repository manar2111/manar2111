using ContactBussinessDataLayar;
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
    public partial class frmListContacts : Form
    {
        public frmListContacts()
        {
            InitializeComponent();
            
        }

        private void _RefreshListContatc()
        {
            dataGridView1.DataSource = clsContact.GetAllContacts();

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            /////
        }
   
        private void MenuDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete contact [" + dataGridView1.CurrentRow.Cells[0].Value + "]", "Confirm Delete", MessageBoxButtons.OKCancel) == DialogResult.OK)

            {

                //Perform Delele and refresh
                if (clsContact.DeleteContact((int)dataGridView1.CurrentRow.Cells[0].Value))
                {
                    MessageBox.Show("Contact Deleted Successfully.");
                    _RefreshListContatc();
                }

                else
                    MessageBox.Show("Contact is not deleted.");

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmAddContacts frmAddCs = new frmAddContacts(-1);
            frmAddCs.ShowDialog();
            _RefreshListContatc();
        }

        private void frmListContacts_Load(object sender, EventArgs e)
        {
            _RefreshListContatc();
        }

        private void MenuEdit_Click(object sender, EventArgs e)
        {
            frmAddContacts fAddContac = new frmAddContacts((int)dataGridView1.CurrentRow.Cells[0].Value);
            fAddContac.ShowDialog();

            _RefreshListContatc();
        }
    }
}
