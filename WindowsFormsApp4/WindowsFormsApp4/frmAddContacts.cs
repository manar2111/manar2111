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
    public partial class frmAddContacts : Form
    {
        enum enMode { enAdd = 0, enEdit = 1 };
        enMode _mode = enMode.enAdd;

        int _ContatID;
        clsContact _contacts;

        public frmAddContacts(int contact)
        {
            InitializeComponent();

            _ContatID = contact;

            if (_ContatID == -1)
            {
                _mode = enMode.enAdd;
            }
            else
            {
                _mode = enMode.enEdit;
            }
        }

        private void _FillCountryComoBox()
        {
            DataTable dtCountry = clsCountry.GetAllCountries();

            foreach (DataRow row in dtCountry.Rows)
            {

                comboBox1.Items.Add(row["CountryName"]);



            }
        }
        private void _LoadData()
        {
            _FillCountryComoBox();
            comboBox1.SelectedIndex = 0;

            if (_mode == enMode.enAdd)
            {
                labTotel.Text = "Add New Contact .";
                _contacts = new clsContact();

                return;
            }

            _contacts = clsContact.Find(_ContatID);

            if (_contacts == null)
            {
                MessageBox.Show("This form will be Closed becouse No Contacts Find ", MessageBoxButtons.OK.ToString());
                this.Close();

                return;
            }

            labTotel.Text = "Edit Contact ID = " + _ContatID;
            ContactIDLab.Text = _ContatID.ToString();
            txtBfirstN.Text = _contacts.FirstName;
            txtBLastN.Text = _contacts.LastName;
            txtBEmail.Text = _contacts.Email;
            txtPhone.Text = _contacts.Phone;
            textBox1.Text = _contacts.Address;
            dateTimePicker1.Value = _contacts.DateOfBirth;

            if (_contacts.ImagePath != " ")
            {
                pictureBox1.Load(_contacts.ImagePath);
            }

            llremove.Visible = (_contacts.ImagePath != " ");

            ///تحول id الى اسم البلد و تحفظه في comobox

            comboBox1.SelectedIndex = comboBox1.FindString(clsCountry.Find(_contacts.CountryID).CountryName);



        }



        private void frmAddContacts_Load(object sender, EventArgs e)
        {
            _LoadData();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            /// int CountryID = clsCountry.Find(comboBox1.Text).ID;
            /// 
            clsCountry country = clsCountry.Find(comboBox1.Text);

            if (country != null)
            {
                int countryID = country.ID;

                _contacts.FirstName = txtBfirstN.Text;
                _contacts.LastName = txtBLastN.Text;
                _contacts.Email = txtBEmail.Text;
                _contacts.Phone = txtPhone.Text;
                _contacts.DateOfBirth = dateTimePicker1.Value;
                _contacts.CountryID = countryID;
                _contacts.Address = textBox1.Text;

                if (pictureBox1.ImageLocation != null)
                {
                    _contacts.ImagePath = pictureBox1.ImageLocation;
                }
                else
                {
                    _contacts.ImagePath = " ";
                }

                if (_contacts.Save())
                {
                    MessageBox.Show("Data Saved Successfully.");
                }
                else
                {
                    MessageBox.Show("Error: Data  Is not Saved Successfully :(");
                }

                _mode = enMode.enEdit;
                labTotel.Text = "Edit Contact ID =" + _contacts.ID;
                ContactIDLab.Text = _contacts.ID.ToString();
            }
            else
            {
                MessageBox.Show("Error : Country is null");
            }


        }


        struct CountryItem
        {
            public string Text;
            public int Value;
            public CountryItem(string Text, int Value)
            {
                this.Text = Text;
                this.Value = Value;
            }
        }

        private void openFileDialog2_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void llsetimage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Process the selected file
                string selectedFilePath = openFileDialog1.FileName;
                //MessageBox.Show("Selected Image is:" + selectedFilePath);

                pictureBox1.Load(selectedFilePath);
                // ...
            }



        }


        private void llremove_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pictureBox1.ImageLocation = null;
            llremove.Visible = false;
        }
    }

}
