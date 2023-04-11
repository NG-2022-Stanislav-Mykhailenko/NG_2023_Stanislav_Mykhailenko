using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitution.Interfaces
{
    public interface IUser
    {
        public string ReadFromFile(string filename);
        public void DownloadFile(string filename);
        public void GetDataFromFile(string filename);
        public void CheckFile(string filename);
    }
}
