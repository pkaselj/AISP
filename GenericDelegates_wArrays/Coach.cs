using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDelegates_wArrays
{
    class Coach
    {
        public string Name { get; set; }
        public string Team { get; set; }
        public Coach(string name)
        {
            Name = name;
        }
        public override string ToString()
        {
            return Name;
        }
    }
}
