using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Microsoft.EntityFrameworkCore.Migrations;
using Model;
using ConnectionSample;
using System.IdentityModel.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace BusinessLogic
{
    public class Logic
    {
        IRepository<Student> repository = new EntityFrameworkRepository<Student>();

        public int GetCountStudent()
        {
            int result = repository.GetStudentList().Count();
            return result;
        }

        public bool IsThereSuchAStudent(int id) {
            List<Student> students = repository.GetStudentList().ToList();

            for (int i = 0; i < students.Count(); i++) {
                if(students[i].Id == id) {
                    return true;
                }
            }

            return false;
        }
        public void AddStudent(string name, string speciality, string group)
        {
            Student student = new Student() {
                name = name,
                speciality = speciality,
                group = group
            };

            repository.CreateStudent(student);
            repository.Save();
        }

        public void DeleteStudent(int index)
        {
            repository.DeleteStudent(index);
        }

        public string[][] GetAllStudentsFormatArrayOfArrays()
        {
            List<Student> students = repository.GetStudentList().ToList();

            string[][] result = new string[repository.GetCountStudents()][];

            for (int i = 0; i < repository.GetCountStudents(); i++) {
                result[i] = new string[] { Convert.ToString(students[i].Id), students[i].name,
                    students[i].speciality, students[i].group };
            }

            return result;
        }

        public Dictionary<string, int> GetCountStudentsOfEverySpeciality()
        {
            List<Student> students = repository.GetStudentList().ToList();

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
                AddStudent(Convert.ToString(i), "Марио", "ИН20-45л");
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
