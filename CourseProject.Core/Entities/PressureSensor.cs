using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProject.Core.Entities
{
    public class PressureSensor
    {
        public Guid Id { get; set; } // Унікальний ідентифікатор
        public string Name { get; set; } // Назва датчика
        public double CurrentPressure { get; set; } // Поточний тиск
        public Guid BoilerId { get; set; } // Ідентифікатор котла
    }
}