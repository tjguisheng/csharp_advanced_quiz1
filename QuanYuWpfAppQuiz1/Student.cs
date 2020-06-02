using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanYuWpfAppQuiz1
{
    public class Student
    {
        public int id { set; get; }
        public string name { set; get; }

        public Student(int id, string name)
        {
            this.id = id;
            this.name = name;
        }
    }
}
