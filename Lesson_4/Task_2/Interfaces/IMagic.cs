using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Open_Closed.Interfaces
{
    public interface IMagic
    {
        string MagicType { get; }

        public void CountYourMagic()
        {
            Console.WriteLine($"Your magic is {MagicType}.");
        }
    }
}
