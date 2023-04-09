namespace LiskovSubstitution
{
    public class User : IWorkingWithFile
    {
        public virtual Guid Role { get; } = new Guid("a65d9c1d-b8a9-4f4f-be9b-ab03856f33f4");

        public string ReadFromFile(string filename)
        {
            return filename;
        }

        public void WriteToFile(string filename)
        {
            Console.WriteLine("Access denied.");
        }

        public void DeleteFile(string filename)
        {
            Console.WriteLine("Access denied.");
        }
        
        public void DownloadFile(string filename)
        {
            Console.WriteLine("Downloaded the file.");
        }

        public void CopyFile(string filename)
        {
            Console.WriteLine("Access denied.");
        }
        
        public void GetDataFromFile(string filename)
        {
            Console.WriteLine("Got data from the file.");
        }
        
        public void CheckFile(string filename)
        {
            Console.WriteLine("Checked the file.");
        }

        public void SaveToFile(string filename)
        {
            Console.WriteLine("Access denied.");
        }

        public Guid CheckRole(Guid role)
        {
            return new Guid("00000000-0000-0000-0000-000000000000");
        }
        
        public Guid CheckUser(Guid user)
        {
            return new Guid("00000000-0000-0000-0000-000000000000");
        }
    }

    public class Administrator : User
    {
        public override Guid Role { get; } = new Guid("c1cfcc4a-e49e-4585-9ccb-265c35321b11");

        public new void WriteToFile(string filename)
        {
            Console.WriteLine("Written to the file.");
        }
        
        public new void DeleteFile(string filename)
        {
            Console.WriteLine("Deleted the file.");
        }

        public new void CopyFile(string filename)
        {
            Console.WriteLine("Copied the file.");
        }

        public new void SaveToFile(string filename)
        {
            Console.WriteLine("Saved to the file.");
        }
    }

    public class Owner : User
    {
        public override Guid Role { get; } = new Guid("a157c9cf-c996-46d7-9905-4cd1319a451d");

        public new Guid CheckRole(Guid role)
        {
            return role;
        }
        
        public new Guid CheckUser(Guid user)
        {
            return user;
        }
    }
}
