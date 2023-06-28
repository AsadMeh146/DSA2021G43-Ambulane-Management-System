using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.IO.File;
namespace DSA2021G43
{
    class PatientManager
    {
        public static string FilePath { get; set; }
        private static PatientManager patientManager = null;
        public List<Patient> patients = new List<Patient>();
        private PatientManager()
        { 
        }
        public static PatientManager getInstance()
        {
            if(patientManager == null)
            {
                patientManager = new PatientManager();
            }
            return patientManager;
        }
        public void writePatientsData()
        {
            List<string> lines = ReadAllLines(FilePath).ToList();
            foreach (Patient patient in patients)
            {
                bool isPresent = false;
                string line = $"{patient.Name},{patient.CNIC},{patient.Age},{patient.Gender},{patient.Date}";
                for (int i = 0; i < lines.Count; i++)
                {
                    string[] words = lines[i].Split(',');
                    if (words[0] == patient.Name)
                        isPresent = true;
                }
                if (!isPresent)
                    lines.Add(line);
            }
            WriteAllLines(FilePath, lines);
        }

    }
}
