﻿using System;
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
    // TODO - add first name lookup option (since last name could be null)and CreateDate (to know when contact was created)
    public partial class ContactsLookupForm : Form
    {

        // initialize a list of Persons for lastNameSearchButton event to add to
        List<PersonModel> contactsReturned = new List<PersonModel>();

        public ContactsLookupForm()
        {
            InitializeComponent();
        }

        // this method could use some separation? some more complexity?

        /// <summary>
        /// This queries our database with user input data.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lastNameSearchButton_Click(object sender, EventArgs e)
        {
            // creating instance of DataAccess so we can call GetPeople method
            DataAccess db = new DataAccess();

            contactsReturned = db.GetContacts(lastNameSearchTextBox.Text);

            // a separate method just for loading the searchResultsListBox
            UpdateBinding();
        }

        // a separate method just for loading the searchResultsListBox
        private void UpdateBinding()
        {
            searchResultsListBox.DataSource = contactsReturned;
            searchResultsListBox.DisplayMember = "FullInfo";
        }
    }
}
