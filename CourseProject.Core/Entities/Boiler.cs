using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProject.Core.Entities
{
    public class Boiler
    {
        public Guid Id { get; set; } // Унікальний ідентифікатор котла
        public string Name { get; set; } // Назва котла
        public string Location { get; set; } // Локація котла
        public DateTime InstallationDate { get; set; } // Дата встановлення
    }
}