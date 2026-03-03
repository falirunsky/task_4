namespace task_4.entities
{
    public class Computer : ICloneable
    {
        public string Processor { get; set; }
        public int Memory { get; set; }
        public string VideoCard { get; set; }
        public List<string> Components { get; set; } = new();

        public object Clone()
        {
            return MemberwiseClone();
        }

        public Computer DeepClone()
        {
            return new Computer
            {
                Processor = Processor,
                Memory = Memory,
                VideoCard = VideoCard,
                Components = new List<string>(Components)
            };
        }

        public void Show()
        {
            Console.WriteLine($"Процесор: {Processor}");
            Console.WriteLine($"Оперативная память: {Memory} гб");
            Console.WriteLine($"Видеокарта: {VideoCard}");
            Console.WriteLine("Доп. компоненты: " + string.Join(", ", Components));
            Console.WriteLine(new string('-', 40));
        }
    }
}
