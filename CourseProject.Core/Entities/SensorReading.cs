using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProject.Core.Entities
{
    public class SensorReading
    {
        public Guid Id { get; set; } // Унікальний ідентифікатор
        public Guid SensorId { get; set; } // Ідентифікатор датчика
        public double Value { get; set; } // Значення
        public DateTime Timestamp { get; set; } // Час запису
    }
}