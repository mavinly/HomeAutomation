using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeAutomation.Library
{
    class DoorSwitchReading
    {
        int ID { get; set; }
        int SensorID { get; set; }
        bool DoorOpen { get; set; }
        DateTime ReadingDateTime { get; set; }
    }
}
