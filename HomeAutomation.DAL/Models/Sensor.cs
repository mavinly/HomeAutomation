using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeAutomation.DAL.Models
{
    public class Sensor
    {
        public Sensor()
        {
            SensorType = new SensorType();
        }

        public int ID { get; set; }
        public int SensorTypeID { get; set; }
        public string Name { get; set; }

        public virtual SensorType SensorType { get; set; }
    }
}
