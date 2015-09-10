using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeAutomation.DAL.Models
{
    public class TemperatureHumiditySensor : SensorReading
    {
        public decimal Temperature { get; set; }
        public decimal Humidity { get; set; }

    }
}
