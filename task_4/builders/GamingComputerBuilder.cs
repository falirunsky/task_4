using System;
using System.Collections.Generic;
using System.Text;
using task_4.entities;
using task_4.interfaces;

namespace task_4.builders
{
    public class GamingComputerBuilder : IComputerBuilder
    {
        private readonly Computer _computer = new();

        public void SetProcessor() => _computer.Processor = "Intel i9";
        public void SetMemory() => _computer.Memory = 32;
        public void SetVideoCard() => _computer.VideoCard = "RTX 4090";
        public void AddComponents() => _computer.Components.AddRange(new[] { "RGB Case", "Liquid Cooling" });
        public Computer GetResult() => _computer;
    }
}
