using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeAutomation.Library
{
    public class DoorSwitchReading
    {
        public int ID { get; set; }
        public int SensorID { get; set; }
        public bool DoorOpen { get; set; }
        public DateTime ReadingDateTime { get; set; }
    }
}
