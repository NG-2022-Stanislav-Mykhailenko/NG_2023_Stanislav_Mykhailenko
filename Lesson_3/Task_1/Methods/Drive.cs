namespace Methods;

using Classes;
using Lists;

class DriveMethods
{
    public bool PurchaseDrive(Drive drive, Computer computer)
    {
        if ((drive.Interface == "PATA" && computer.Motherboard.UsedPataSlots != computer.Motherboard.PataSlots) || (drive.Interface == "SATA" && computer.Motherboard.UsedSataSlots != computer.Motherboard.SataSlots))
        {
            if (drive.Interface == "PATA")
                computer.Motherboard.UsedPataSlots++;
            else
                computer.Motherboard.UsedSataSlots++;
            computer.Drives.Add(drive);
            computer.Price += drive.Price;
            return true;
        }
        return false;
    }

    public void RemoveDrive(Drive drive, Computer computer)
    {
            if (drive.Interface == "PATA")
                computer.Motherboard.UsedPataSlots--;
            else
                computer.Motherboard.UsedSataSlots--;
            computer.Drives.Remove(drive);
            computer.Price -= drive.Price;
    }

    public void DisplayDrive(Drive drive)
    {
       string? SsdAdditional = drive.Lifetime != null ? $"lifetime {drive.Lifetime} TBW, " : "";
       Console.WriteLine($"{drive.Name} manufactured by {drive.Supplier} from {drive.Country}, size {drive.Size} GB, speed {drive.Speed} MB/s, interface {drive.Interface}, {SsdAdditional}costs {drive.Price} ¤");
    }

    public void DisplayDriveList(Computer computer, List<Drive> data, bool remove = false)
    {
        if (!data.Any())
        {
            Console.WriteLine("No data available.");
            return;
        }

        foreach (Drive drive in data)
            DisplayDrive(drive);

        while (true)
        {
            try
            {
                Console.Write("Enter the drive name: ");
                string? input = Console.ReadLine();
                var selected = (from drive in data where drive.Name == input select drive).First();
                if (!remove)
                {
                    if (PurchaseDrive(selected, computer))
                        Console.WriteLine("Purchased.");
                    else
                        Console.WriteLine("This drive cannot be installed in your computer.");
                }
                else
                {
                    RemoveDrive(selected, computer);
                    Console.WriteLine("Removed.");
                }
                return;
            }
            catch (InvalidOperationException)
            {
                Console.WriteLine("Not found.");
            }
        }
    }
}
