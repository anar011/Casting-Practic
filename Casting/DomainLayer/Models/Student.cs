﻿using DomainLayer.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Models
{
    public class Student : BaseEntity
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string  Email { get; set; }

        public int Age { get; set; }
        public string Education  { get; set; }

        public string Address { get; set; }
    }
}
