using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeAutomation.Model.DoorSwitchReading;

namespace HomeAutomation.BusinessServices
{
    public interface IDoorSwitch
    {
        List<DoorSwitchDTO> GetReadings();
        void RecordReading(DoorSwitchDTO dsr);
    }
}
