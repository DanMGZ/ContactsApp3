namespace ContactsUI
{
    partial class CreateNewContactForm
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
            this.newContactHeaderLabel = new System.Windows.Forms.Label();
            this.newPhoneNumberLabel = new System.Windows.Forms.Label();
            this.newLastNameLabel = new System.Windows.Forms.Label();
            this.newFirstNameLabel = new System.Windows.Forms.Label();
            this.newFirstNameTextBox = new System.Windows.Forms.TextBox();
            this.newLastNameTextBox = new System.Windows.Forms.TextBox();
            this.newPhoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.saveNewContactButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // newContactHeaderLabel
            // 
            this.newContactHeaderLabel.AutoSize = true;
            this.newContactHeaderLabel.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newContactHeaderLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.newContactHeaderLabel.Location = new System.Drawing.Point(13, 9);
            this.newContactHeaderLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.newContactHeaderLabel.Name = "newContactHeaderLabel";
            this.newContactHeaderLabel.Size = new System.Drawing.Size(350, 50);
            this.newContactHeaderLabel.TabIndex = 1;
            this.newContactHeaderLabel.Text = "Create New Contact";
            // 
            // newPhoneNumberLabel
            // 
            this.newPhoneNumberLabel.AutoSize = true;
            this.newPhoneNumberLabel.Location = new System.Drawing.Point(15, 185);
            this.newPhoneNumberLabel.Name = "newPhoneNumberLabel";
            this.newPhoneNumberLabel.Size = new System.Drawing.Size(210, 40);
            this.newPhoneNumberLabel.TabIndex = 2;
            this.newPhoneNumberLabel.Text = "Phone Number";
            // 
            // newLastNameLabel
            // 
            this.newLastNameLabel.AutoSize = true;
            this.newLastNameLabel.Location = new System.Drawing.Point(15, 131);
            this.newLastNameLabel.Name = "newLastNameLabel";
            this.newLastNameLabel.Size = new System.Drawing.Size(153, 40);
            this.newLastNameLabel.TabIndex = 3;
            this.newLastNameLabel.Text = "Last Name";
            // 
            // newFirstNameLabel
            // 
            this.newFirstNameLabel.AutoSize = true;
            this.newFirstNameLabel.Location = new System.Drawing.Point(15, 79);
            this.newFirstNameLabel.Name = "newFirstNameLabel";
            this.newFirstNameLabel.Size = new System.Drawing.Size(155, 40);
            this.newFirstNameLabel.TabIndex = 4;
            this.newFirstNameLabel.Text = "First Name";
            // 
            // newFirstNameTextBox
            // 
            this.newFirstNameTextBox.Location = new System.Drawing.Point(231, 76);
            this.newFirstNameTextBox.Name = "newFirstNameTextBox";
            this.newFirstNameTextBox.Size = new System.Drawing.Size(382, 46);
            this.newFirstNameTextBox.TabIndex = 5;
            // 
            // newLastNameTextBox
            // 
            this.newLastNameTextBox.Location = new System.Drawing.Point(231, 128);
            this.newLastNameTextBox.Name = "newLastNameTextBox";
            this.newLastNameTextBox.Size = new System.Drawing.Size(382, 46);
            this.newLastNameTextBox.TabIndex = 6;
            // 
            // newPhoneNumberTextBox
            // 
            this.newPhoneNumberTextBox.Location = new System.Drawing.Point(231, 182);
            this.newPhoneNumberTextBox.Name = "newPhoneNumberTextBox";
            this.newPhoneNumberTextBox.Size = new System.Drawing.Size(382, 46);
            this.newPhoneNumberTextBox.TabIndex = 7;
            // 
            // saveNewContactButton
            // 
            this.saveNewContactButton.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.saveNewContactButton.Location = new System.Drawing.Point(400, 245);
            this.saveNewContactButton.Name = "saveNewContactButton";
            this.saveNewContactButton.Size = new System.Drawing.Size(213, 45);
            this.saveNewContactButton.TabIndex = 8;
            this.saveNewContactButton.Text = "Save New Contact";
            this.saveNewContactButton.UseVisualStyleBackColor = true;
            this.saveNewContactButton.Click += new System.EventHandler(this.saveNewContactButton_Click);
            // 
            // CreateNewContactForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 40F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(692, 333);
            this.Controls.Add(this.saveNewContactButton);
            this.Controls.Add(this.newPhoneNumberTextBox);
            this.Controls.Add(this.newLastNameTextBox);
            this.Controls.Add(this.newFirstNameTextBox);
            this.Controls.Add(this.newFirstNameLabel);
            this.Controls.Add(this.newLastNameLabel);
            this.Controls.Add(this.newPhoneNumberLabel);
            this.Controls.Add(this.newContactHeaderLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 21.75F);
            this.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.Name = "CreateNewContactForm";
            this.Text = "CreateNewContactForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label newContactHeaderLabel;
        private System.Windows.Forms.Label newPhoneNumberLabel;
        private System.Windows.Forms.Label newLastNameLabel;
        private System.Windows.Forms.Label newFirstNameLabel;
        private System.Windows.Forms.TextBox newFirstNameTextBox;
        private System.Windows.Forms.TextBox newLastNameTextBox;
        private System.Windows.Forms.TextBox newPhoneNumberTextBox;
        private System.Windows.Forms.Button saveNewContactButton;
    }
}