using System;

namespace ContactsApp.Data
{
    public class Contact
    {
        private String _name;
        private double _mobileNumber;

        public Contact(String name, double mobileNumber)
        {
            _name = name;
            _mobileNumber = mobileNumber;
        }

        public String Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public double MobileNumber
        {
            get { return _mobileNumber; }
            set { _mobileNumber = value; }
        }
    }
}
