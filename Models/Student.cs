﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Student : Person
    {
        public int StudentID { get; set; }

        public string RegistrationNumber { get; set; }
    }
}
