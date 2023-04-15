﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Open_Closed.Interfaces;

namespace Open_Closed.Classes
{
    public class Magic : IMagic
    {
        public void CountYourMagic(IMagicClass MagicClass)
        {
            Console.WriteLine($"Your magic is {MagicClass.MagicType}.");
        }
    }
}
