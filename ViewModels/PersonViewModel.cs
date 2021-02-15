using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModels
{
    public class PersonViewModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/mm/yyyy}")]
        public DateTime? Birthday { get; set; }

        public int Type { get; set; }

        //Student
        public int? CourseId { get; set; }

        public int? NReg { get; set; }

        public decimal? Grade { get; set; }

        //Teacher
        public decimal? Salary { get; set; }
    }
}
