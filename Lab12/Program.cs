using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();
            people.Add(new Staff("Niels", "Seatle","Harvard", 150000));
            people.Add(new Student("Jordan", "Warren", "CSC", 2019, 4000));
            people.Add(new Person("testing", "hERE?"));
            Console.WriteLine(people[0].ToString());
            Console.WriteLine(people[1].ToString());
            Console.WriteLine(people[2].ToString());
        }
    }
}
