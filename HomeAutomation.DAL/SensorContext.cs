using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeAutomation.DAL.Models;

namespace HomeAutomation.DAL
{
    public class SensorContext : DbContext
    {
        public DbSet<Sensor> Sensor { get; set; }
        public DbSet<SensorType> SensorType { get; set; }
        public DbSet<SensorReading> SensorReading { get; set; }
        public DbSet<TemperatureHumiditySensor> TemperatureHumiditySensor { get; set; }
        public DbSet<DoorSwitchSensor> DoorSwitchSensor { get; set; } 
    }
}
