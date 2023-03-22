namespace Methods;

using Classes;
using Lists;

class CpuMethods
{
    public bool PurchaseCpu(Cpu cpu, Computer computer)
    {
        if (cpu.Socket == computer.Motherboard.Socket && computer.Motherboard.UsedCpuSlots != computer.Motherboard.CpuSlots)
        {
            computer.Motherboard.UsedCpuSlots++;
            computer.Cpus.Add(cpu);
            computer.Price += cpu.Price;
            return true;
        }
        return false;
    }

    public void RemoveCpu(Cpu cpu, Computer computer)
    {
            computer.Motherboard.UsedCpuSlots--;
            computer.Cpus.Remove(cpu);
            computer.Price -= cpu.Price;
    }

    public void DisplayCpu(Cpu cpu)
    {
        Console.WriteLine($"{cpu.Name} manufactured by {cpu.Supplier} from {cpu.Country}, socket {cpu.Socket}, cores: {cpu.Cores}, frequency {cpu.Frequency} MHz, costs {cpu.Price} ¤");
    }

    public void DisplayCpuList(Computer computer, List<Cpu> data, bool remove = false)
    {
        if (!data.Any())
        {
            Console.WriteLine("No data available.");
            return;
        }

        foreach (Cpu cpu in data)
           DisplayCpu(cpu);

        while (true)
        {
            try
            {
                Console.Write("Enter the CPU name: ");
                string? input = Console.ReadLine();
                var selected = (from cpu in data where cpu.Name == input select cpu).First();
                if (!remove)
                {
                    if (PurchaseCpu(selected, computer))
                        Console.WriteLine("Purchased.");
                    else
                        Console.WriteLine("This CPU cannot be installed in your computer.");
                }
                else
                {
                    RemoveCpu(selected, computer);
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
