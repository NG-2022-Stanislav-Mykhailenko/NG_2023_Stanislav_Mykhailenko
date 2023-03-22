namespace Classes;

using Lists;
using Methods;

class Computer
{
    public Motherboard Motherboard { get; set; }
    public List<Ram> Rams { get; set; } = new List<Ram>();
    public List<Cpu> Cpus { get; set; } = new List<Cpu>();
    public List<Gpu> Gpus { get; set; } = new List<Gpu>();
    public List<Drive> Drives { get; set; } = new List<Drive>();
    public int Price { get; set; } = 0;

    public void DisplayInstalledMotherboard()
    {
        Console.WriteLine("Motherboard: ");
        (new MotherboardMethods()).DisplayMotherboard(Motherboard);
    }

    public void DisplayInstalledRams()
    {
        Console.WriteLine($"RAM ({Motherboard.RamType}): {Motherboard.UsedRamSlots}/{Motherboard.RamSlots}");
        foreach (Ram ram in Rams)
            (new RamMethods()).DisplayRam(ram);
    }

    public void DisplayInstalledCpus()
    {
        Console.WriteLine($"CPUs ({Motherboard.Socket}): {Motherboard.UsedCpuSlots}/{Motherboard.CpuSlots}");
        foreach (Cpu cpu in Cpus)
            (new CpuMethods()).DisplayCpu(cpu);
    }

    public void DisplayInstalledGpus()
    {
        Console.WriteLine("GPUs:");
        foreach (Gpu gpu in Gpus)
            (new GpuMethods()).DisplayGpu(gpu);
    }

    public void DisplayInstalledDrives()
    {
        Console.WriteLine($"Drives (PATA {Motherboard.UsedPataSlots}/{Motherboard.PataSlots}, SATA {Motherboard.UsedSataSlots}/{Motherboard.SataSlots}):");
        foreach (Drive drive in Drives)
            (new DriveMethods()).DisplayDrive(drive);
    }

    public void Display()
    {
        DisplayInstalledMotherboard();
        DisplayInstalledRams();
        DisplayInstalledCpus();
        DisplayInstalledGpus();
        DisplayInstalledDrives();
    }

    public void Replace(Motherboard motherboard)
    {
        Motherboard = motherboard;
        Rams.Clear();
        Cpus.Clear();
        Gpus.Clear();
        Drives.Clear();
        Price = motherboard.Price;
    }

    public void Checkout(int money)
    {
        while (true)
        {
            int choice;
            Display();
    
            if (!Rams.Any() || !Cpus.Any() || !Gpus.Any() || !Drives.Any())
                Console.WriteLine("\nThis computer lacks some details.");
    
            Console.WriteLine($"\nTotal cost: {Price}");
            if (money - Price < 0)
                Console.WriteLine("You cannot afford this computer.");

            Console.WriteLine("Remove RAMs [1]\nRemove CPUs [2]\nRemove GPUs [3]\nRemove Drives [4]\nReplace motherboard (removes everything else) [5]\nGo back [6]");
            if (int.TryParse(Console.ReadLine(), out choice))
            {
                switch (choice)
                {
                    case 1:
                        (new RamMethods()).DisplayRamList(this, Rams, true);
                        break;
                    case 2:
                        (new CpuMethods()).DisplayCpuList(this, Cpus, true);
                        break;
                    case 3:
                        (new GpuMethods()).DisplayGpuList(this, Gpus, true);
                        break;
                    case 4:
                        (new DriveMethods()).DisplayDriveList(this, Drives, true);
                        break;
                    case 5:
                        Motherboard motherboard = (new MotherboardMethods()).DisplayMotherboardList();
                        this.Replace(motherboard);
                        break;
                    case 6:
                        goto Back;
                }
            }
        }
        Back:
            Console.WriteLine("Going back…");
    }

    public Computer(Motherboard motherboard)
    {
        Motherboard = motherboard;
        Price = motherboard.Price;
    }
}
