using System.Text;
using task_4;
using task_4.factories;

class Program
{
    static void Main()
    {

        Console.OutputEncoding = Encoding.UTF8;
        Console.InputEncoding = Encoding.UTF8;

        var officeFactory = new OfficeFactory();
        var gamingFactory = new GamingFactory();

        var officePc = officeFactory.CreateComputer();
        var gamingPc = gamingFactory.CreateComputer();

        PrototypeRegistry.Instance.Register("ОФисный", officePc);
        PrototypeRegistry.Instance.Register("Игровой", gamingPc);

        var shallow = PrototypeRegistry.Instance.GetShallowClone("Игровой");
        var deep = PrototypeRegistry.Instance.GetDeepClone("Игровой");

        shallow.Components.Add("Дополнительный ССД");

        Console.WriteLine("Ориг:");
        gamingPc.Show();

        Console.WriteLine("Поверхностный клон:");
        shallow.Show();

        Console.WriteLine("Глубокий клон:");
        deep.Show();
    }
}