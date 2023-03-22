namespace Methods;

using Classes;
using Lists;

class MotherboardMethods
{
    public void PurchaseMotherboard(Motherboard motherboard, Computer computer)
    {
        computer.Motherboard = motherboard;
        computer.Price += motherboard.Price;
    }

    public void DisplayMotherboard(Motherboard motherboard)
    {
        Console.WriteLine($"{motherboard.Name} manufactured by {motherboard.Supplier} from {motherboard.Country}, RAM type {motherboard.RamType}, slots {motherboard.RamSlots}, socket {motherboard.Socket}, CPU slots {motherboard.CpuSlots}, PATA slots {motherboard.PataSlots}, SATA slots {motherboard.SataSlots}, costs {motherboard.Price} ¤");
    }

    public Motherboard DisplayMotherboardList()
    {
        List<Motherboard> motherboards = (new MotherboardsForSale()).Hardware;
        foreach (Motherboard motherboard in motherboards)
           DisplayMotherboard(motherboard);
        while (true)
        {
            try
            {
                Console.Write("Enter the motherboard name to purchase: ");
                string? input = Console.ReadLine();
                var selected = (from motherboard in motherboards where motherboard.Name == input select motherboard).First();
                Console.WriteLine("Purchased.");
                return selected;
            }
            catch (InvalidOperationException)
            {
                Console.WriteLine("Not found.");
            }
        }
    }

}
