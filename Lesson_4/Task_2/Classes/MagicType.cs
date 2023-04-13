using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Open_Closed.Interfaces;

namespace Open_Closed.Classes
{
    public class MagicType : IMagicType
    {
        public string Name { get; set; }
        public int Value { get; set; }

        public MagicType(string name, int value)
        {
            Name = name;
            Value = value;
        }
    }
}
