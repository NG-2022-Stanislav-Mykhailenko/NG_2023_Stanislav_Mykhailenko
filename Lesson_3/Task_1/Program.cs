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

computer.HardwareSelection(money);
