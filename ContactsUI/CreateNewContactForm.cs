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
            if (ValidateForm())
            {
                DataAccess db = new DataAccess();

                // could create a PersonModel instance and pass that to Insert Contact
                // actually I have to so I can store the id output with person.ID = listOfVariables.Get<int>("@ID") over there
                PersonModel person = new PersonModel();
                person.FirstName = newFirstNameTextBox.Text;
                person.LastName = newLastNameTextBox.Text;
                person.PhoneNumber = newPhoneNumberTextBox.Text;

                //db.InsertContact(newFirstNameTextBox.Text, newLastNameTextBox.Text, newPhoneNumberTextBox.Text);
                db.InsertContact(person);

                newFirstNameTextBox.Text = "";
                newLastNameTextBox.Text = "";
                newPhoneNumberTextBox.Text = "";

                MessageBox.Show($"Your new contact's ID is {person.ID}");
            }
            else
            {
                // Consider creating a class of standard messages
                MessageBox.Show("Please fill out all fields.");
            }
        }

        //should we have a validate form class instead?
        private bool ValidateForm()
        {
            bool output = true;

            if (string.IsNullOrWhiteSpace(newFirstNameTextBox.Text))
            {
                output = false;
            }

            if (string.IsNullOrWhiteSpace(newLastNameTextBox.Text))
            {
                output = false;
            }

            if (string.IsNullOrWhiteSpace(newPhoneNumberTextBox.Text))
            {
                output = false;
            }
            return output;
        }
    }
}
