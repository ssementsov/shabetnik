using System;

namespace T106
{
    internal class VideoCard : Computer
    {
        public VideoCard(int cost, int weight, int videoMemory)
            : base(cost, weight)
        {
            this.VideoMemory = videoMemory;
        }

        private int VideoMemory { get; set; }

        public void PrintVideoCard()
        {
            Console.WriteLine($"\r\nVideoMemory: {this.VideoMemory}");
        }
    }
}
