using System;
using System.Collections.Generic;
using System.Text;
using task_4.entities;
using task_4.interfaces;

namespace task_4
{
    public class ComputerDirector
    {
        public Computer Construct(IComputerBuilder builder)
        {
            builder.SetProcessor();
            builder.SetMemory();
            builder.SetVideoCard();
            builder.AddComponents();
            return builder.GetResult();
        }
    }
}
