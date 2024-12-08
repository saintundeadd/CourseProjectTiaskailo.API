using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProject.Core.Interfaces
{
    public interface ISensor
    {
        Guid Id { get; set; }
        string Name { get; set; }
        double ReadValue(); // Метод для зчитування значення
    }
}