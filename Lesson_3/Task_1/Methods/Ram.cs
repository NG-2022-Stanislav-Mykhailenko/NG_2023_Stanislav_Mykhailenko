namespace Methods;

using Classes;
using Lists;

class RamMethods
{
    public bool PurchaseRam(Ram ram, Computer computer)
    {
        if (ram.Type == computer.Motherboard.RamType && computer.Motherboard.UsedRamSlots != computer.Motherboard.RamSlots)
        {
            computer.Motherboard.UsedRamSlots++;
            computer.Rams.Add(ram);
            computer.Price += ram.Price;
            return true;
        }
        return false;
    }

    public void RemoveRam(Ram ram, Computer computer)
    {
            computer.Motherboard.UsedRamSlots--;
            computer.Rams.Remove(ram);
            computer.Price -= ram.Price;
    }

    public void DisplayRam(Ram ram)
    {
        Console.WriteLine($"{ram.Name} manufactured by {ram.Supplier} from {ram.Country}, type {ram.Type}, size {ram.Size} GB, costs {ram.Price} ¤");
    }

    public void DisplayRamList(Computer computer, List<Ram> data, bool remove = false)
    {
        if (!data.Any())
        {
            Console.WriteLine("No data available.");
            return;
        }

        foreach (Ram ram in data)
           DisplayRam(ram);

        while (true)
        {
            try
            {
                Console.Write("Enter the RAM name: ");
                string? input = Console.ReadLine();
                var selected = (from ram in data where ram.Name == input select ram).First();
                if (!remove)
                {
                    if (PurchaseRam(selected, computer))
                        Console.WriteLine("Purchased.");
                    else
                        Console.WriteLine("This RAM cannot be installed in your computer.");
                }
                else
                {
                    RemoveRam(selected, computer);
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
