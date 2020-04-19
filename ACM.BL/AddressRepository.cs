using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class AddressRepository
    {
        public Address Retreive(int addressId)
        {
            Address address = new Address(addressId);

            if (addressId == 1)
            {
                address.AddressType = 1;
                address.City = "NY";
                address.Country = "US";
                address.PostalCode = "1234";
                address.State = "NY";
                address.StreetLine1 = "asd";
                address.StreetLine2 = "asdf";

            }

            return address;
        }

        public IEnumerable<Address> RetreiveByCustomerId (int customerId)
            {
            var addressList = new List<Address>();
            Address address = new Address(1)
            {
                AddressType = 1,
                City = "NY",
                Country = "US",
                PostalCode = "1234",
                State = "NY",
                StreetLine1 = "asd",
                StreetLine2 = "asdf"
            };
            addressList.Add(address);

            address = new Address(2)
            {
                AddressType = 2,
                City = "NYv",
                Country = "USv",
                PostalCode = "12vv4",
                State = "NYv",
                StreetLine1 = "avvsd",
                StreetLine2 = "asdvvf"
            };
            addressList.Add(address);

            return addressList;
        }

        public bool Save(Address address)
        {
            var success = true;

            if (address.HasChanges)
            {
                if (address.IsValid)
                {
                    if (address.IsNew)
                    {

                    }
                    else
                    {

                    }
                }
                else
                {
                    success = false;
                }
            }

            return success;
        }
    }
}
