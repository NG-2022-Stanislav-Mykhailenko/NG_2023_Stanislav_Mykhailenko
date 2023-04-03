using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Open_Closed
{
    public class FireMagic : Magic
    {
        public override void CountYourMagic() 
        {
            Console.WriteLine("Wow, your magic is fire magic!");
        }
    }

    public class WaterMagic : Magic
    {
        public override void CountYourMagic() 
        {
            Console.WriteLine("Incredible! You have 50 millions of power! It's water magic!");
        }
    }

    public class Magic
    {
        public virtual void CountYourMagic() 
        {
            Console.WriteLine("I understand you...");
        }
    }
}
