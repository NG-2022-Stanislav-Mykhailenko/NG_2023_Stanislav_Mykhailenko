using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Open_Closed.Interfaces;

namespace Open_Closed.Classes
{
    public class UnknownMagic : IMagic
    {
        public void CountYourMagic() 
        {
            Console.WriteLine("I understand you...");
        }
    }
}
