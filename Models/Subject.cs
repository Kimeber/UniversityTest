using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Subject
    {
        public int SubjectID { get; set; }

        public Course Course { get; set; }

        public Teacher Teacher { get; set; }

        public List<SubjectStudent> Students { get; set; }
    }
}
