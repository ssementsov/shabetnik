using System;

namespace T106
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int costCPU = 400;
            int costVC = 600;
            int allCost = costCPU + costVC;
            int weightCPU = 150;
            int weightVC = 320;
            int allWeight = weightCPU + weightVC;
            Computer computer = new Computer(allCost, allWeight);
            CPU cPU = new CPU(costCPU, weightCPU, 200);
            VideoCard videoCard = new VideoCard(costVC, weightVC, 24);

            // в зависимости от того, что нужно вывести меняем только эту (21) строку
            computer.PrintComputer();

            // cPU.PrintCPUComputer();
            // videoCard.PrintVideoCard();
            Console.ReadKey();
        }
    }
}
