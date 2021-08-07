using System;
using System.Collections.Generic;

namespace ContactAppLib.Data
{
    public class Contact
    {
        private Guid _guid;
        private String _name;
        private double _contactNo;
        private List<Address> _addresses;

        public Contact(String name, double contactNo, String address):this(Guid.NewGuid(), name, contactNo, address)
        {

        }

        public Contact(Guid guid, String name, double contactNo) : this(guid, name, contactNo, "")
        {

        }
        public Contact(Guid guid, String name, double contactNo, String address)
        {
            _guid = guid;
            _name = name;
            _contactNo = contactNo;
            _addresses = new List<Address>();
            _addresses.Add(new Address(address));
        }

        public Guid Guid
        {
            get { return _guid; }
        }
        public String Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public double ContactNo
        {
            get { return _contactNo; }
            set { _contactNo = value; }
        }
        public List<Address> Addresses
        {
            get { return _addresses; }
            set { _addresses = value; }
        }
    }
}
