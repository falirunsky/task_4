using task_4.interfaces;
using task_4.entities;

namespace task_4.builders
{
    public class OfficeComputerBuilder : IComputerBuilder
    {
        private readonly Computer _computer = new();

        public void SetProcessor() => _computer.Processor = "Intel i3";
        public void SetMemory() => _computer.Memory = 8;
        public void SetVideoCard() => _computer.VideoCard = "Integrated";
        public void AddComponents() => _computer.Components.AddRange(new[] { "Keyboard", "Mouse" });
        public Computer GetResult() => _computer;
    }
}
