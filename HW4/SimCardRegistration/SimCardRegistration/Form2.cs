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
    public partial class Form2 : Form
    {
        public Form2(string mobile, string firstname, string lastname, string sex, string status, DateTime birthday, string location, Image userImage)
        {
            InitializeComponent();
           
            txtMobile.Text = mobile;
            txtFirstname.Text = firstname;
            txtLastname.Text = lastname;
            txtLocation.Text = location;

            
            if (sex == "Male")
                rdoMale.Checked = true;
            else if (sex == "Female")
                rdoFemale.Checked = true;

            
            cmbStatus.Items.AddRange(new string[] { "Single", "Married", "Widowed", "Separated" });
            cmbStatus.Text = status;


            dtpBirthday.Value = birthday;

            
            if (userImage != null)
                pictureBox2.Image = userImage;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
