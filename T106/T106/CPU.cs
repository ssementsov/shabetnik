using System;

namespace T106
{
    internal class CPU : Computer
    {
        public CPU(int cost, int weight, int power)
            : base(cost, weight)
        {
            this.Power = power;
        }

        private int Power { get; set; }

        public void PrintCPUComputer()
        {
            Console.WriteLine($"\r\nPower: {this.Power}");
        }
    }
}
