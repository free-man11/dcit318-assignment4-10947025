using System;
using System.Windows.Forms;
// hey there

namespace AddressBookApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string email = txtEmail.Text;
            string phoneNumber = txtPhoneNumber.Text;
            MessageBox.Show($"Name: {name}\nEmail: {email}\nPhone Number: {phoneNumber}", "Saved Information");
        }
    }
}
