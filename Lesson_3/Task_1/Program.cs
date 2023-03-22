using Classes;
using Lists;
using Methods;

int money;

while (true)
{
    Console.Write("Enter how much money you can afford to spend: ");
    if (int.TryParse(Console.ReadLine(), out money))
        break;
}

Console.WriteLine("Choose a motherboard first.");
Motherboard motherboard = (new MotherboardMethods()).DisplayMotherboardList();
Computer computer = new Computer(motherboard);

while (true)
{
    int choice;
    Console.WriteLine("RAMs [1]\nCPUs [2]\nGPUs [3]\nDrives [4]\nCheckout [5]\nQuit [6]");
    Console.Write("Enter a number: ");
    if (int.TryParse(Console.ReadLine(), out choice))
    {
        switch (choice)
        {
            case 1:
                (new RamMethods()).DisplayRamList(computer, (new RamsForSale()).Hardware);
                break;
            case 2:
                (new CpuMethods()).DisplayCpuList(computer, (new CpusForSale()).Hardware);
                break;
            case 3:
                (new GpuMethods()).DisplayGpuList(computer, (new GpusForSale()).Hardware);
                break;
            case 4:
                (new DriveMethods()).DisplayDriveList(computer, (new DrivesForSale()).Hardware);
                break;
            case 5:
                computer.Checkout(money);
                break;
            case 6:
                goto Exit;
        }
    }
}

Exit:
    Console.WriteLine("Goodbye.");
