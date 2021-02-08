using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public abstract class Person
    {
        public int PersonID { get; set; }

        public string Name { get; set; }

        public DateTime Birthday { get; set; }
    }
}
