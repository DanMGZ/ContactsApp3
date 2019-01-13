namespace ContactsUI
{
    partial class ContactsLookupForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.headerLabel = new System.Windows.Forms.Label();
            this.lastNameLookupLabel = new System.Windows.Forms.Label();
            this.searchResultsListBox = new System.Windows.Forms.ListBox();
            this.clearSearchResultsButton = new System.Windows.Forms.Button();
            this.lastNameSearchTextBox = new System.Windows.Forms.TextBox();
            this.lastNameSearchButton = new System.Windows.Forms.Button();
            this.createNewContactButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Segoe UI", 27.75F);
            this.headerLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.headerLabel.Location = new System.Drawing.Point(22, 9);
            this.headerLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(282, 50);
            this.headerLabel.TabIndex = 0;
            this.headerLabel.Text = "Contact Lookup";
            // 
            // lastNameLookupLabel
            // 
            this.lastNameLookupLabel.AutoSize = true;
            this.lastNameLookupLabel.Location = new System.Drawing.Point(24, 72);
            this.lastNameLookupLabel.Name = "lastNameLookupLabel";
            this.lastNameLookupLabel.Size = new System.Drawing.Size(153, 40);
            this.lastNameLookupLabel.TabIndex = 1;
            this.lastNameLookupLabel.Text = "Last Name";
            // 
            // searchResultsListBox
            // 
            this.searchResultsListBox.FormattingEnabled = true;
            this.searchResultsListBox.ItemHeight = 40;
            this.searchResultsListBox.Location = new System.Drawing.Point(31, 177);
            this.searchResultsListBox.Name = "searchResultsListBox";
            this.searchResultsListBox.Size = new System.Drawing.Size(621, 164);
            this.searchResultsListBox.TabIndex = 2;
            // 
            // clearSearchResultsButton
            // 
            this.clearSearchResultsButton.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.clearSearchResultsButton.Location = new System.Drawing.Point(31, 347);
            this.clearSearchResultsButton.Name = "clearSearchResultsButton";
            this.clearSearchResultsButton.Size = new System.Drawing.Size(214, 42);
            this.clearSearchResultsButton.TabIndex = 3;
            this.clearSearchResultsButton.Text = "Clear Results";
            this.clearSearchResultsButton.UseVisualStyleBackColor = true;
            this.clearSearchResultsButton.Click += new System.EventHandler(this.clearSearchResultsButton_Click);
            // 
            // lastNameSearchTextBox
            // 
            this.lastNameSearchTextBox.Location = new System.Drawing.Point(31, 115);
            this.lastNameSearchTextBox.Name = "lastNameSearchTextBox";
            this.lastNameSearchTextBox.Size = new System.Drawing.Size(401, 46);
            this.lastNameSearchTextBox.TabIndex = 4;
            // 
            // lastNameSearchButton
            // 
            this.lastNameSearchButton.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.lastNameSearchButton.Location = new System.Drawing.Point(438, 116);
            this.lastNameSearchButton.Name = "lastNameSearchButton";
            this.lastNameSearchButton.Size = new System.Drawing.Size(214, 45);
            this.lastNameSearchButton.TabIndex = 5;
            this.lastNameSearchButton.Text = "Search";
            this.lastNameSearchButton.UseVisualStyleBackColor = true;
            this.lastNameSearchButton.Click += new System.EventHandler(this.lastNameSearchButton_Click);
            // 
            // createNewContactButton
            // 
            this.createNewContactButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createNewContactButton.Location = new System.Drawing.Point(438, 347);
            this.createNewContactButton.Name = "createNewContactButton";
            this.createNewContactButton.Size = new System.Drawing.Size(214, 42);
            this.createNewContactButton.TabIndex = 6;
            this.createNewContactButton.Text = "Create New Contact";
            this.createNewContactButton.UseVisualStyleBackColor = true;
            this.createNewContactButton.Click += new System.EventHandler(this.createNewContactButton_Click);
            // 
            // ContactsLookupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 40F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(685, 412);
            this.Controls.Add(this.createNewContactButton);
            this.Controls.Add(this.lastNameSearchButton);
            this.Controls.Add(this.lastNameSearchTextBox);
            this.Controls.Add(this.clearSearchResultsButton);
            this.Controls.Add(this.searchResultsListBox);
            this.Controls.Add(this.lastNameLookupLabel);
            this.Controls.Add(this.headerLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.Name = "ContactsLookupForm";
            this.Text = "Contact Lookup";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.Label lastNameLookupLabel;
        private System.Windows.Forms.ListBox searchResultsListBox;
        private System.Windows.Forms.Button clearSearchResultsButton;
        private System.Windows.Forms.TextBox lastNameSearchTextBox;
        private System.Windows.Forms.Button lastNameSearchButton;
        private System.Windows.Forms.Button createNewContactButton;
    }
}

