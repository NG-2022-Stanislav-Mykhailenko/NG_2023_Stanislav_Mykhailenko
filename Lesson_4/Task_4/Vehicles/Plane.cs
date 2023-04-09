using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using LiskovSubstitution.Interfaces;

namespace LiskovSubstitution.Vehicles
{
    public class Plane : Vehicle, IFlyable
    {
        public virtual void Fly()
        {
            Console.WriteLine("It's flying?");
        }
    }
}
