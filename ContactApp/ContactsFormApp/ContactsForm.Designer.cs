
namespace ContactsFormApp
{
    partial class ContactsForm
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
            this.displayContactWithAddressButton = new System.Windows.Forms.Button();
            this.dataGridContacts = new System.Windows.Forms.DataGridView();
            this.addContactButton = new System.Windows.Forms.Button();
            this.displayContactButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridContacts)).BeginInit();
            this.SuspendLayout();
            // 
            // displayContactWithAddressButton
            // 
            this.displayContactWithAddressButton.Location = new System.Drawing.Point(12, 12);
            this.displayContactWithAddressButton.Name = "displayContactWithAddressButton";
            this.displayContactWithAddressButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.displayContactWithAddressButton.Size = new System.Drawing.Size(234, 44);
            this.displayContactWithAddressButton.TabIndex = 0;
            this.displayContactWithAddressButton.Text = "Show Contacts With Address";
            this.displayContactWithAddressButton.UseVisualStyleBackColor = true;
            this.displayContactWithAddressButton.Click += new System.EventHandler(this.displayContactWithAddressButton_Click);
            // 
            // dataGridContacts
            // 
            this.dataGridContacts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridContacts.Location = new System.Drawing.Point(3, 62);
            this.dataGridContacts.Name = "dataGridContacts";
            this.dataGridContacts.RowHeadersWidth = 51;
            this.dataGridContacts.RowTemplate.Height = 24;
            this.dataGridContacts.Size = new System.Drawing.Size(795, 376);
            this.dataGridContacts.TabIndex = 1;
            this.dataGridContacts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridContacts_CellContentClick);
            // 
            // addContactButton
            // 
            this.addContactButton.Location = new System.Drawing.Point(667, 12);
            this.addContactButton.Name = "addContactButton";
            this.addContactButton.Size = new System.Drawing.Size(121, 44);
            this.addContactButton.TabIndex = 2;
            this.addContactButton.Text = "Add Contact";
            this.addContactButton.UseVisualStyleBackColor = true;
            this.addContactButton.Click += new System.EventHandler(this.addContactButton_Click);
            // 
            // displayContactButton
            // 
            this.displayContactButton.Location = new System.Drawing.Point(368, 12);
            this.displayContactButton.Name = "displayContactButton";
            this.displayContactButton.Size = new System.Drawing.Size(144, 44);
            this.displayContactButton.TabIndex = 3;
            this.displayContactButton.Text = "Show Contacts";
            this.displayContactButton.UseVisualStyleBackColor = true;
            this.displayContactButton.Click += new System.EventHandler(this.displayContactButton_Click);
            // 
            // ContactsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.displayContactButton);
            this.Controls.Add(this.addContactButton);
            this.Controls.Add(this.dataGridContacts);
            this.Controls.Add(this.displayContactWithAddressButton);
            this.Name = "ContactsForm";
            this.Text = "Contacts Manager";
            this.Load += new System.EventHandler(this.ContactsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridContacts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button displayContactWithAddressButton;
        private System.Windows.Forms.DataGridView dataGridContacts;
        private System.Windows.Forms.Button addContactButton;
        private System.Windows.Forms.Button displayContactButton;
    }
}

