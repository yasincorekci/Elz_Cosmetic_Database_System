using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class EntityEmployee
    {
        private int Ssn;
        private string FirstName;
        private string LastName;
        private string Birthdate;
        private int Age;
        private int Dno;
        private string Gender;
        private string Country;
        private string City;
        private int Salary;
        private string DName;

        public int Ssn1 { get => Ssn; set => Ssn = value; }
        public string FirstName1 { get => FirstName; set => FirstName = value; }
        public string LastName1 { get => LastName; set => LastName = value; }
        public string Birthdate1 { get => Birthdate; set => Birthdate = value; }
        public int Age1 { get => Age; set => Age = value; }
        public int Dno1 { get => Dno; set => Dno = value; }
        public string Gender1 { get => Gender; set => Gender = value; }
        public string Country1 { get => Country; set => Country = value; }
        public string City1 { get => City; set => City = value; }
        public int Salary1 { get => Salary; set => Salary = value; }
        public string DName1 { get => DName; set => DName = value; }
    }
}
