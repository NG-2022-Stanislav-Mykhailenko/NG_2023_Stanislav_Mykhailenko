using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Open_Closed.Interfaces;

namespace Open_Closed.Classes
{
    public class WaterMagic : IMagic
    {
        public void CountYourMagic() 
        {
            Console.WriteLine("Incredible! You have 50 millions of power! It's water magic!");
        }
    }
}
