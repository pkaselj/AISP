using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericMethods
{
    public interface IAccount
    {
        string Name { get; set; }
        decimal Balance { get; set; }
    }
}
