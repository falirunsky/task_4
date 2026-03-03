using task_4.entities;
using task_4.interfaces;

namespace task_4.builders
{
    public class HomeComputerBuilder : IComputerBuilder
    {
        private readonly Computer _computer = new();

        public void SetProcessor() => _computer.Processor = "Ryzen 5";
        public void SetMemory() => _computer.Memory = 16;
        public void SetVideoCard() => _computer.VideoCard = "RTX 3060";
        public void AddComponents() => _computer.Components.AddRange(new[] { "WiFi Adapter" });
        public Computer GetResult() => _computer;
    }
}
