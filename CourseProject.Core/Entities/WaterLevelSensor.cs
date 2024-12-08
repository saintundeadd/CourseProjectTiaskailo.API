using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProject.Core.Entities
{
    public class WaterLevelSensor
    {
        public Guid Id { get; set; } // Унікальний ідентифікатор
        public string Name { get; set; } // Назва датчика
        public double CurrentWaterLevel { get; set; } // Поточний рівень води у відсотках
        public Guid BoilerId { get; set; } // Ідентифікатор котла
    }
}