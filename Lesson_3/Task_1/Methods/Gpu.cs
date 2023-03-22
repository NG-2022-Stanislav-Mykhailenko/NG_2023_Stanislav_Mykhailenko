namespace Methods;

using Classes;
using Lists;

class GpuMethods
{
    public void PurchaseGpu(Gpu gpu, Computer computer)
    {
        computer.Gpus.Add(gpu);
        computer.Price += gpu.Price;
    }

    public void RemoveGpu(Gpu gpu, Computer computer)
    {
            computer.Gpus.Remove(gpu);
            computer.Price -= gpu.Price;
    }

    public void DisplayGpu(Gpu gpu)
    {
        Console.WriteLine($"{gpu.Name} manufactured by {gpu.Supplier} from {gpu.Country}, memory {gpu.Memory} GB, speed {gpu.Speed} MHz, costs {gpu.Price} ¤");
    }

    public void DisplayGpuList(Computer computer, List<Gpu> data, bool remove = false)
    {
        if (!data.Any())
        {
            Console.WriteLine("No data available.");
            return;
        }

        foreach (Gpu gpu in data)
           DisplayGpu(gpu);

        while (true)
        {
            try
            {
                Console.Write("Enter the GPU name to purchase: ");
                string? input = Console.ReadLine();
                var selected = (from gpu in data where gpu.Name == input select gpu).First();
                if (!remove)
                {
                    PurchaseGpu(selected, computer);
                    Console.WriteLine("Purchased.");
                }
                else
                {
                    RemoveGpu(selected, computer);
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
