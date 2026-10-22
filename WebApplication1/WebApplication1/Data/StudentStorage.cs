using WebApplication1.Models;

namespace WebApplication1.Data
{
    public class StudentStorage
    {
        private readonly List<Student> _students = [];
        private int _sljedeciId = 1;

        public StudentStorage() 
        {
            Dodaj(new Student()
            {
                Ime = "Enis",
                Prezime = "Dzemidzic",
                BrojIndeksa = "IB230203",
                DatumRodjenja = new DateOnly(2004, 10, 7)
            });

            Dodaj(new Student()
            {
                Ime = "Azra",
                Prezime = "Smajic",
                BrojIndeksa = "IB234203",
                DatumRodjenja = new DateOnly(2004, 10, 7)
            });
        }


        public Student Dodaj(Student student)
        {
            student.Id = _sljedeciId++;
            student.DatumKreiranja = DateTime.UtcNow;
            _students.Add(student);

            return student;
        }
        public List<Student> GetAll() {
        
            return _students;
        }
    }
}
