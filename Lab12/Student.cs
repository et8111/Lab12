using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{
    class Student: Person
    {
        public string Program { get;}
        public int Year { get;}
        public double Fee { get;}
        public Student(string name, string address, string program, int year, double fee):base(name, address)
        {
            Program = program;
            Year = year;
            Fee = fee;
        }
        public override string ToString()
        {
            return base.ToString()+$" {Program} student in the class of {Year}, I PAY {Fee.ToString("C2")}.";
        }
    }
}
