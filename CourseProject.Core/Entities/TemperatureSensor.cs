using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProject.Core.Entities
{
    public class TemperatureSensor
    {
        public Guid Id { get; set; } // Унікальний ідентифікатор
        public string Name { get; set; } // Назва датчика
        public double CurrentTemperature { get; set; } // Поточна температура
        public Guid BoilerId { get; set; } // Ідентифікатор котла
    }
}