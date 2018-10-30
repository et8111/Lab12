﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{
    class Staff: Person
    {
        public string School { get;}
        public double Pay { get;}

        public Staff(string name, string address,string school, double pay): base(name, address)
        {
            School = school;
            Pay = pay;
        }

        public override string ToString()
        {
            return base.ToString()+ $" I work at {School}, and get paid {Pay.ToString("C2")}";
        }
    }
}
