using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimCardRegistration
{
    public partial class Form1 : Form
    {
        Image selectedImage;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                selectedImage = Image.FromFile(open.FileName);
                pictureBox1.Image = selectedImage;
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string mobile = txtMobile.Text;
            string firstname = txtFirstname.Text;
            string lastname = txtLastname.Text;
            string sex = rdoMale.Checked ? "Male" : "Female";
            string status = cmbStatus.Text;
            DateTime birthday = dtpBirthday.Value;
            string location = txtLocation.Text;

            
            Form2 f2 = new Form2(mobile, firstname, lastname, sex, status, birthday, location, selectedImage);
            f2.Show();
        }

        private void txtMobile_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
