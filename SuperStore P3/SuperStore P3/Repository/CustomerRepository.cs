﻿using Data;
using Models;

namespace EcoPower_Logistics.Repository
{
    public class CustomerRepository : GenericRepository<Customer>, iCustomers
    {
        public CustomerRepository(SuperStoreContext context) : base(context)
        {
        }

        public Customer GetMostRecentCustomer()
        {
            return _context.Customers.OrderByDescending(service => service.CreatedDate).FirstOrDefault();
        }
    }

}
