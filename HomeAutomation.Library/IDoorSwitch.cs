using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeAutomation.BusinessServices
{
    interface IDoorSwitch
    {
        List<DoorSwitchReading> GetReadings();
        void RecordReading(DoorSwitchReading dsr);
    }
}
