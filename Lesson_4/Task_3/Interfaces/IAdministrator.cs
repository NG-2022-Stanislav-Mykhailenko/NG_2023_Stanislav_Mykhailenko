using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitution.Interfaces
{
    public interface IAdministrator : IUser
    {
        public void WriteToFile(string filename);
        public void DeleteFile(string filename);
        public void CopyFile(string filename);
        public void SaveToFile(string filename);
    }
}
