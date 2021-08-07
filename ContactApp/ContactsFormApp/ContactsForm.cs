using ContactAppLib.Service;
using System;
using System.Windows.Forms;
using ContactAppLib.Data;
using System.Collections.Generic;

namespace ContactsFormApp
{
    public partial class ContactsForm : Form
    {
        private IContactService _contactService;

        public ContactsForm()
        {
            InitializeComponent();
            _contactService = new SqlDatabaseService();
        }

        private void displayContactWithAddressButton_Click(object sender, EventArgs e)
        {
            RefreshDataGridView();
            dataGridContacts.DataSource = _contactService.GetContactsWithAddress();
            AddButtonColumnToDataGridView();
        }

        private void displayContactButton_Click(object sender, EventArgs e)
        {
            RefreshDataGridView();
            dataGridContacts.DataSource = _contactService.GetContacts();
        }

        private void ShowAddress(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                DataGridView dataGridView = (DataGridView)sender;
                DataGridViewRow row = dataGridView.Rows[e.RowIndex];
                List<Address> addressesList;
                String addresses = "";

                addressesList = _contactService.GetAddresses(Guid.Parse(row.Cells[0].Value.ToString()));
                foreach(Address address in addressesList)
                {
                    addresses += address.AddressData + "\n";
                }

                MessageBox.Show(addresses);
            }
        }

        private void addContactButton_Click(object sender, EventArgs e)
        {
            AddContactForm addContactForm = new AddContactForm(_contactService);
            addContactForm.Show();
        }

        private void RefreshDataGridView()
        {
            dataGridContacts.DataSource = null;
            dataGridContacts.Columns.Clear();
            dataGridContacts.Refresh();
        }

        private void AddButtonColumnToDataGridView()
        {
            DataGridViewButtonColumn dataGridViewButtonColumn = new DataGridViewButtonColumn();
            dataGridViewButtonColumn.Text = "View Address";
            dataGridViewButtonColumn.UseColumnTextForButtonValue = true;

            dataGridContacts.Columns.Add(dataGridViewButtonColumn);
        }

        private void dataGridContacts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ShowAddress(sender, e);
        }

        private void ContactsForm_Load(object sender, EventArgs e)
        {

        }
    }
}
