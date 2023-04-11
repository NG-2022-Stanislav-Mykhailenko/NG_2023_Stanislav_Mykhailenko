using LiskovSubstitution.Interfaces;

namespace LiskovSubstitution.Classes
{
    public class User : IUser
    {

        public string ReadFromFile(string filename)
        {
            return filename;
        }
        
        public void DownloadFile(string filename)
        {
            Console.WriteLine("Downloaded the file.");
        }
        
        public void GetDataFromFile(string filename)
        {
            Console.WriteLine("Got data from the file.");
        }
        
        public void CheckFile(string filename)
        {
            Console.WriteLine("Checked the file.");
        }
    }
}
