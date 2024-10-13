using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Student : IDomainObject {
        public int Id { get; set; }
        public string name {  get; set; }
        public string speciality { get; set; }
        public string group { get; set; }
    }
}
