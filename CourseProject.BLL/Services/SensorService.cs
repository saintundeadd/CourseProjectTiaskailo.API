using CourseProject.BLL.Interfaces;
using CourseProject.DAL.Repositories;
using System;
using System.Collections.Generic;

namespace CourseProject.BLL.Services
{
    public class SensorService<T> : ISensorService<T> where T : class
    {
        private readonly IRepository<T> _sensorRepository;

        public SensorService(IRepository<T> sensorRepository)
        {
            _sensorRepository = sensorRepository;
        }

        public IEnumerable<T> GetAllSensors()
        {
            return _sensorRepository.GetAll();
        }

        public T GetSensorById(Guid id)
        {
            return _sensorRepository.GetById(id);
        }

        public void AddSensor(T sensor)
        {
            if (sensor == null)
            {
                throw new ArgumentNullException(nameof(sensor), "Sensor cannot be null.");
            }

            _sensorRepository.Add(sensor);
        }

        public void UpdateSensor(T sensor)
        {
            if (sensor == null)
            {
                throw new ArgumentNullException(nameof(sensor), "Sensor cannot be null.");
            }

            _sensorRepository.Update(sensor);
        }

        public void DeleteSensor(Guid id)
        {
            var sensor = _sensorRepository.GetById(id);
            if (sensor == null)
            {
                throw new ArgumentException($"Sensor with ID {id} does not exist.");
            }

            _sensorRepository.Delete(id);
        }
    }
}