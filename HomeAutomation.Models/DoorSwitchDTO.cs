using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeAutomation.Model.DoorSwitchReading
{
    public class DoorSwitchDTO
    {
        public int ID { get; set; }
        public string Open { get; set; }
        public DateTime ReadingDateTime { get; set; }
        public string SensorName { get; set; }
        public int SensorID { get; set; }
    }
}
