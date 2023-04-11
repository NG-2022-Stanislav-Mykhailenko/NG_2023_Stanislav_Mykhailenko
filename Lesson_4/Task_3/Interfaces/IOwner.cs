using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitution.Interfaces
{
    public interface IOwner : IAdministrator
    {
        public Guid CheckRole(Guid role);
        public Guid CheckUser(Guid user);
    }
}
