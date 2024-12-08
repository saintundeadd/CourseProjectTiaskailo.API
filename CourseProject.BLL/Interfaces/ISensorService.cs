using System;
using System.Collections.Generic;

namespace CourseProject.BLL.Interfaces
{
    public interface ISensorService<T> where T : class
    {
        IEnumerable<T> GetAllSensors();
        T GetSensorById(Guid id);
        void AddSensor(T sensor);
        void UpdateSensor(T sensor);
        void DeleteSensor(Guid id);
    }
}