﻿using ECommerceBackend.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceBackend.Entities.Concrete
{
    public class Customer : IEntity
    {
        [Key]
        public int CustomerId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string  Password{ get; set; }
        public string  Phone { get; set; }
        public string  Address { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
    }
}
