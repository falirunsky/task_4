using System;
using System.Collections.Generic;
using System.Text;
using task_4.entities;

namespace task_4.interfaces
{
    public interface IComputerBuilder
    {
        void SetProcessor();
        void SetMemory();
        void SetVideoCard();
        void AddComponents();
        Computer GetResult();
    }
}
