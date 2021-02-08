using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModels
{
    public class PersonViewModel
    {
        public int PersonID { get; set; }

        public int TypeID { get; set; }

        public string Name { get; set; }

        public DateTime Birthday { get; set; }

        public string RegistrationNumber { get; set; }

        public decimal? Salary { get; set; }
    }
}
