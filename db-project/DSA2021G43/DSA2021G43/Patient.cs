using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA2021G43
{
    class Patient
    {
        public string Name { get; set; }
        public string CNIC { get; set; }
        public string Age { get; set; }
        public string Gender { get; set; }
        public string Date { get; set; }
        public Patient(string name,string cnic,string age,string gender,string date)
        {
            Name = name;
            CNIC = cnic;
            Age = age;
            Gender = gender;
            Date = date;
        }
    }
}
