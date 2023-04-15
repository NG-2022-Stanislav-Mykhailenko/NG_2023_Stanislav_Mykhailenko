using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Open_Closed.Interfaces;

namespace Open_Closed.Classes
{
    public class FireMagic : Magic, IMagic
    {
        public override int MagicValue { get { return 150; } }
        public override string MagicType { get { return "fire"; } }
    }
}
