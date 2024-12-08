using CourseProject.Core.Entities;
using System;
using System.Collections.Generic;

namespace CourseProject.BLL.Interfaces
{
    public interface IBoilerService
    {
        IEnumerable<Boiler> GetAllBoilers();
        Boiler GetBoilerById(Guid id);
        void AddBoiler(Boiler boiler);
        void UpdateBoiler(Boiler boiler);
        void DeleteBoiler(Guid id);
    }
}