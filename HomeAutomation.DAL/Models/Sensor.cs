using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeAutomation.DAL.Models
{
    public class Sensor
    {
        public int ID { get; set; }
        public int SensorTypeID { get; set; }
        public string Name { get; set; }

        public virtual SensorType SensorType { get; set; }
        public virtual List<SensorReading> SensorReadings { get; set; } 
    }
}
