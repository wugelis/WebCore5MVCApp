﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace MingChi.Domain.CRMs.Models
{
    public partial class Customer
    {
        public Customer()
        {
            CustomerCustomerDemos = new HashSet<CustomerCustomerDemo>();
            Orders = new HashSet<Order>();
        }
        [Key]
        public string CustomerId { get; set; }
        public string CompanyName { get; set; }
        public string ContactName { get; set; }
        public string ContactTitle { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }

        public virtual ICollection<CustomerCustomerDemo> CustomerCustomerDemos { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}
