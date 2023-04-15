using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Open_Closed.Interfaces;

namespace Open_Closed.Classes
{
    abstract public class Magic : IMagic
    {
        abstract public int MagicValue { get; }
        abstract public string MagicType { get; }

        public void CountYourMagic()
        {
            Console.WriteLine($"Your magic is {MagicType}.");
        }
    }
}
