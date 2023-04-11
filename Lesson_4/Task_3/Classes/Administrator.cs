using LiskovSubstitution.Interfaces;

namespace LiskovSubstitution.Classes
{
    public class Administrator : User, IAdministrator
    {

        public void WriteToFile(string filename)
        {
            Console.WriteLine("Written to the file.");
        }
        
        public void DeleteFile(string filename)
        {
            Console.WriteLine("Deleted the file.");
        }

        public void CopyFile(string filename)
        {
            Console.WriteLine("Copied the file.");
        }

        public void SaveToFile(string filename)
        {
            Console.WriteLine("Saved to the file.");
        }
    }
}
