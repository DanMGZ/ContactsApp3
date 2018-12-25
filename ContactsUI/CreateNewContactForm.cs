using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ContactsLibrary;

namespace ContactsUI
{
    public partial class CreateNewContactForm : Form
    {
        public CreateNewContactForm()
        {
            InitializeComponent();
        }

        private void saveNewContactButton_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();

            db.InsertContact(newFirstNameTextBox.Text, newLastNameTextBox.Text, newPhoneNumberTextBox.Text);

            newFirstNameTextBox.Text = "";
            newLastNameTextBox.Text = null;
            newPhoneNumberTextBox.Text = "";
        }
    }
}
