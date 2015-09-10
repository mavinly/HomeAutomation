using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeAutomation.DAL.Models
{
    public class SensorReading
    {
        public int ID { get; set; }
        public int SensorID { get; set; }
        public DateTime ReadingDateTime { get; set; }

        public virtual Sensor Sensor { get; set; }
    }
}
