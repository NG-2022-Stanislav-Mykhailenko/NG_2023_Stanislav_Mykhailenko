using LiskovSubstitution.Interfaces;

namespace LiskovSubstitution.Classes
{
    public class Owner : Administrator, IOwner
    {

        public Guid CheckRole(Guid role)
        {
            return role;
        }
        
        public Guid CheckUser(Guid user)
        {
            return user;
        }
    }
}
