using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class UniversityInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<ModelContainer>
    {
        protected override void Seed(ModelContainer context)
        {
            var departaments = new List<Departament>
            {
                new Departament {Name = "Computer Science Departament" },
                new Departament {Name = "Mechanic Departament" },
                new Departament {Name = "Mathmatical Departament" },
                new Departament {Name = "Biology Departament" }
            };
            departaments.ForEach(d => context.Departament.Add(d));
            context.SaveChanges();

            var courses = new List<Course>
            {
                new Course{Title="Computer Science and Engineering",Credits=180,DepartamentId=1},
                new Course{Title="Big Data",Credits=120, DepartamentId=1},
                new Course{Title="Mechanical Engineering",Credits=180, DepartamentId=2},
                new Course{Title="Automation",Credits=180,DepartamentId=2},
                new Course{Title="Trigonometry",Credits=120, DepartamentId=3},
            };
            courses.ForEach(s => context.Course.Add(s));
            context.SaveChanges();


            var persons = new List<Person>
            {
                new Person{Name="John Doe"},
                new Person{Name="Carson Alexander"},
                new Person{Name="Arturo Anand"},
                new Person{Name="Gytis Barzdukas"},
                new Person{Name="Yan Li"},
                new Person{Name="Peggy Justice"},
                new Person{Name="Laura Norman"},
            };
            persons.ForEach(s => context.Person.Add(s));
            context.SaveChanges();

            var teachers = new List<Teacher>
            {
                new Teacher{PersonId=1,Salary=2000},
                new Teacher{PersonId=2,Salary=1500},
                new Teacher{PersonId=3,Salary=1800}
            };
            teachers.ForEach(s => context.Teacher.Add(s));
            context.SaveChanges();

            var students = new List<Student>
            {
                new Student{PersonId=4,nReg=123132},
                new Student{PersonId=5,nReg=123456},
                new Student{PersonId=6,nReg=523432},
                new Student{PersonId=7,nReg=876532}
            };
            students.ForEach(s => context.Student.Add(s));
            context.SaveChanges();

            var subjects = new List<Subject>
            {
                new Subject{Name="Introduction", CourseId=1,TeacherId=1,Credits=6},
                new Subject{Name="Microprocessors", CourseId=1,TeacherId=1,Credits=9},
                new Subject{Name="Programming", CourseId=1,TeacherId=1,Credits=5},
                new Subject{Name="Oriented Objects", CourseId=1,TeacherId=1,Credits=10},
                new Subject{Name="Math Analysis", CourseId=2,TeacherId=2,Credits=5},
                new Subject{Name="Accounting", CourseId=5,TeacherId=3,Credits=5},
                new Subject{Name="Finance", CourseId=5,TeacherId=3,Credits=3},
                new Subject{Name="Databases", CourseId=1,TeacherId=1,Credits=9}
            };
            subjects.ForEach(s => context.Subject.Add(s));
            context.SaveChanges();

            var classStudents = new List<ClassStudent>
            {
                new ClassStudent{StudentId=1,SubjectId=1,Grade=14},
                new ClassStudent{StudentId=1,SubjectId=2,Grade=10},
                new ClassStudent{StudentId=1,SubjectId=3,Grade=11},
                new ClassStudent{StudentId=1,SubjectId=4,Grade=17},
                new ClassStudent{StudentId=1,SubjectId=8,Grade=12},
                new ClassStudent{StudentId=2,SubjectId=6,Grade=12},
                new ClassStudent{StudentId=2,SubjectId=7,Grade=13},
                new ClassStudent{StudentId=3,SubjectId=1,Grade=10},
                new ClassStudent{StudentId=3,SubjectId=2,Grade=7},
                new ClassStudent{StudentId=3,SubjectId=3,Grade=13},
                new ClassStudent{StudentId=3,SubjectId=4,Grade=11},
                new ClassStudent{StudentId=3,SubjectId=8,Grade=17},
                new ClassStudent{StudentId=4,SubjectId=1,Grade=12},
                new ClassStudent{StudentId=4,SubjectId=2,Grade=15},
                new ClassStudent{StudentId=4,SubjectId=3,Grade=19},
                new ClassStudent{StudentId=4,SubjectId=4,Grade=15},
                new ClassStudent{StudentId=4,SubjectId=8,Grade=16}
            };
            classStudents.ForEach(s => context.ClassStudent.Add(s));
            context.SaveChanges();
        }

    }
}

