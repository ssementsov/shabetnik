using System;

namespace T106
{
    internal class Computer
    {
        public Computer(int cost, int weight)
        {
            this.Cost = cost;
            this.Weight = weight;
        }

        private int Cost { get; set; }

        private int Weight { get; set; }

        public void PrintComputer()
        {
            Console.WriteLine($"Cost :{this.Cost}");
            Console.WriteLine($"\r\nWeight: {this.Weight}");
        }
    }
}
