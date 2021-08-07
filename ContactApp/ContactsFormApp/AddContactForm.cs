using System;
using System.Windows.Forms;
using ContactAppLib.Service;
using ContactAppLib.Data;

namespace ContactsFormApp
{
    public partial class AddContactForm : Form
    {
        private IContactService _contactService;
        public AddContactForm(IContactService contactService)
        {
            InitializeComponent();
            _contactService = contactService;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            Contact contact;
            contact = new Contact(nameTextBox.Text, Convert.ToDouble(mobileNoTextBox.Text), addressTextBox.Text);
            _contactService.AddContact(contact);
            MessageBox.Show("Contact Added Successfully.");
            this.Close();
        }
    }
}
