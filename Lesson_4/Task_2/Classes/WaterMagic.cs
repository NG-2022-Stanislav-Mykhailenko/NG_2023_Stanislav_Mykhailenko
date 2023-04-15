using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Open_Closed.Interfaces;

namespace Open_Closed.Classes
{
    public class WaterMagic : Magic, IMagic
    {
        public override int MagicValue { get { return 50000000; } }
        public override string MagicType { get { return "water"; } }
    }
}
