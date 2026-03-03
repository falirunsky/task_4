using System;
using System.Collections.Generic;
using System.Text;
using task_4.builders;
using task_4.entities;
using task_4.interfaces;

namespace task_4.factories
{
    public abstract class Factories
    {
        public abstract IComputerBuilder CreateBuilder();

        public Computer CreateComputer()
        {
            var director = new ComputerDirector();
            return director.Construct(CreateBuilder());
        }
    }
    public class OfficeFactory : Factories
    {
        public override IComputerBuilder CreateBuilder() => new OfficeComputerBuilder();
    }

    public class GamingFactory : Factories
    {
        public override IComputerBuilder CreateBuilder() => new GamingComputerBuilder();
    }

    public class HomeFactory : Factories
    {
        public override IComputerBuilder CreateBuilder() => new HomeComputerBuilder();
    }
}
