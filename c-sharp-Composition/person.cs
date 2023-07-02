using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_Composition
{
    internal class person
    {
        string name { get; set; }
        dog dog1 { get; set; }

        public person(string name,dog dog1)
        {
            this.name = name;
            this.dog1 = dog1;
        }

    }
}
