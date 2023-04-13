using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Open_Closed.Interfaces;

namespace Open_Closed.Classes
{
    public class Magic : IMagic
    {
        private List<MagicType> MagicTypes;

        public Magic(List<MagicType> magicTypes)
        {
            MagicTypes = magicTypes;
        }

        public void CountYourMagic(int magic) 
        {
            foreach(var magicType in MagicTypes)
            {
                if(magic == magicType.Value)
                {
                    Console.WriteLine($"Wow, your magic is {magicType.Name}!");
                    return;
                }
            }

            Console.WriteLine("I understand you...");
        }
    }
}
