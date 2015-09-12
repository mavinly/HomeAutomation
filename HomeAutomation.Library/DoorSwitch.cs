using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeAutomation.DAL;

namespace HomeAutomation.BusinessServices
{
    public class DoorSwitch : IDoorSwitch
    {
        List<DoorSwitchReading> _dsr;

        public DoorSwitch()
        {
            _dsr = new List<DoorSwitchReading>()
            {
                new DoorSwitchReading() {ID = 1, SensorID = 1, ReadingDateTime = new DateTime(2015, 8, 27, 5, 0, 0), DoorOpen = false},
                new DoorSwitchReading() { ID = 2, SensorID = 1, ReadingDateTime = new DateTime(2015, 8, 27, 5, 0, 0), DoorOpen = false }
             };

            using (var db = new SensorContext())
            {
                var query = from b in db.DoorSwitchSensor
                            select b;
            }
        }

        public List<DoorSwitchReading> GetReadings()
        {
            return _dsr;
        }

        public void RecordReading(DoorSwitchReading dsr)
        {
            _dsr.Add(dsr);
        }
    }
}
