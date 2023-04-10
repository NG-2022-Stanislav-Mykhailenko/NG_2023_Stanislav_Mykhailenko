using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Open_Closed.Interfaces;

namespace Open_Closed.Classes
{
    public class FireMagic : IMagic
    {
        public void CountYourMagic() 
        {
            Console.WriteLine("Wow, your magic is fire magic!");
        }
    }
}
