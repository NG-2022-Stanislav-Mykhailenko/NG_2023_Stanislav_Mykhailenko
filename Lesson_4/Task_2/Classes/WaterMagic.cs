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
        public int MagicValue { get { return 50000000; } }
        public string MagicType { get { return "water"; } }
    }
}
