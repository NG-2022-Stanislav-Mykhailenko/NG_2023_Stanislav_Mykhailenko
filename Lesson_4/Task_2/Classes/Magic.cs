using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Open_Closed.Interfaces;

namespace Open_Closed.Classes
{
    public abstract class Magic : IMagic
    {
        public abstract int MagicValue { get; }
        public abstract string MagicType { get; }

        public void CountYourMagic()
        {
            Console.WriteLine($"Your magic is {MagicType}.");
        }
    }
}
