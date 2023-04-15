using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Open_Closed.Interfaces
{
    public interface IMagic
    {
        abstract int MagicValue { get; }
        abstract string MagicType { get; }

        void CountYourMagic();
    }
}
