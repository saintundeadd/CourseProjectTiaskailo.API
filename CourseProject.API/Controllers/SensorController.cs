using CourseProject.BLL.Interfaces;
using CourseProject.Core.Entities;
using Microsoft.AspNetCore.Mvc;

namespace CourseProject.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SensorController : ControllerBase
    {
        private readonly ISensorService<TemperatureSensor> _temperatureSensorService;
        private readonly ISensorService<PressureSensor> _pressureSensorService;
        private readonly ISensorService<WaterLevelSensor> _waterLevelSensorService;

        public SensorController(
            ISensorService<TemperatureSensor> temperatureSensorService,
            ISensorService<PressureSensor> pressureSensorService,
            ISensorService<WaterLevelSensor> waterLevelSensorService)
        {
            _temperatureSensorService = temperatureSensorService;
            _pressureSensorService = pressureSensorService;
            _waterLevelSensorService = waterLevelSensorService;
        }

        // Отримати всі датчики температури
        [HttpGet("temperature")]
        public IActionResult GetAllTemperatureSensors()
        {
            var sensors = _temperatureSensorService.GetAllSensors();
            return Ok(sensors);
        }

        // Отримати всі датчики тиску
        [HttpGet("pressure")]
        public IActionResult GetAllPressureSensors()
        {
            var sensors = _pressureSensorService.GetAllSensors();
            return Ok(sensors);
        }

        // Отримати всі датчики рівня води
        [HttpGet("waterlevel")]
        public IActionResult GetAllWaterLevelSensors()
        {
            var sensors = _waterLevelSensorService.GetAllSensors();
            return Ok(sensors);
        }

        // Додати датчик температури
        [HttpPost("temperature")]
        public IActionResult AddTemperatureSensor([FromBody] TemperatureSensor sensor)
        {
            if (sensor == null)
                return BadRequest("Sensor data is null");

            _temperatureSensorService.AddSensor(sensor);
            return CreatedAtAction(nameof(GetAllTemperatureSensors), new { id = sensor.Id }, sensor);
        }

        // Додати датчик тиску
        [HttpPost("pressure")]
        public IActionResult AddPressureSensor([FromBody] PressureSensor sensor)
        {
            if (sensor == null)
                return BadRequest("Sensor data is null");

            _pressureSensorService.AddSensor(sensor);
            return CreatedAtAction(nameof(GetAllPressureSensors), new { id = sensor.Id }, sensor);
        }

        // Додати датчик рівня води
        [HttpPost("waterlevel")]
        public IActionResult AddWaterLevelSensor([FromBody] WaterLevelSensor sensor)
        {
            if (sensor == null)
                return BadRequest("Sensor data is null");

            _waterLevelSensorService.AddSensor(sensor);
            return CreatedAtAction(nameof(GetAllWaterLevelSensors), new { id = sensor.Id }, sensor);
        }
    }
}