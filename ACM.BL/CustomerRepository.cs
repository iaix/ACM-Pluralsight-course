﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class CustomerRepository
    {
        public CustomerRepository()
        {
            addressRepository = new AddressRepository();
        }
        private AddressRepository addressRepository { get; set; }
        public Customer Retreive(int customerId)
        {
            Customer customer = new Customer(customerId);

            if (customerId==1)
            {
                customer.FirstName = "Bilbo";
                customer.LastName = "Baggins";
                customer.EmailAddress = "fbaggins@hobbiton.co";
                customer.AddressList = addressRepository.RetreiveByCustomerId(customerId).ToList();
            }

            return customer;
        }


        public bool Save(Customer customer)
        {
            var success = true;

            if (customer.HasChanges)
            {
                if (customer.IsValid)
                {
                    if (customer.IsNew)
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
