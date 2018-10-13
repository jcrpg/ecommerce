﻿using EcommerceApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceApplication.Services.Infrastructure
{
    public interface ICustomer
    {
        IEnumerable<Customer> GetAll();

        Customer GetById(int id);

        void Insert(Customer customer);

        void Update(Customer customer);

        void Delete(int id);

        int Count();

        void Save();
    }
}
