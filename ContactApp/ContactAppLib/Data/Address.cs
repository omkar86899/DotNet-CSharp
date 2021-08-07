using System;

namespace ContactAppLib.Data
{
    public class Address
    {
        private String _address;

        public Address(String address)
        {
            _address = address;
        }

        public String AddressData
        {
            get { return _address; }
        }
    }
}
