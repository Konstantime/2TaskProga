using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Model;

namespace BusinessLogic
{
    public class Logic
    {
        private List<Student> students { get; set; }
            = new List<Student>();

        public int GetCountStudent()
        {
            return students.Count;
        }
        public void AddStudent(string name, string speciality, string group)
        {
            students.Add(new Student() { name = name, speciality = speciality, group = group });
        }

        public void DeleteStudent(int index)
        {
            if (index >= 0 && students.Count > index) {
                students.RemoveAt(index);
            }
        }

        public string[][] GetAllStudentsFormatArrayOfArrays()
        {
            string[][] result = new string[students.Count][];

            for( int i = 0; i < students.Count; i++ )
            {
                result[i] = new string[] { students[i].name, 
                    students[i].speciality, students[i].group };
            }

            return result;
        }

        public Dictionary<string, int> GetCountStudentsOfEverySpeciality()
        {
            Dictionary<string, int> result = new Dictionary<string, int>();
            foreach (var student in students)
            {
                string specialityOfStudent = student.speciality;
                if ( result.ContainsKey(specialityOfStudent) )
                {
                    result[student.speciality]++;
                }
                else
                {
                    result.Add(specialityOfStudent, 1 );
                }
            }

            return result;
        }

        public void FillTableWithDemoData()
        {
            for (int i = 0; i < 1; i++)
            {
                AddStudent(Convert.ToString(i), "Повар", "ИН20-45л");
            }
            for (int i = 0; i < 5; i++) {
                AddStudent(Convert.ToString(i), "Программист", "КИ23-21б");
            }
            for (int i = 0; i < 3; i++) {
                AddStudent(Convert.ToString(i), "Моряк", "ФИ26-7б");
            }
        }
    }
}
