using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{
    class Person
    {
        public string Name { get;}
        public string Address { get;}
        public Person(string name, string address)
        {
            Name = name;
            Address = address;
        }
        public override string ToString()
        {
            return $"My Name is {Name}, I live in {Address}.";
        }
    }
}
