using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeAutomation.DAL;
using HomeAutomation.Model.DoorSwitchReading;

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

            using (var db = new HomeAutomationEntities())
            {
                var query = from b in db.SensorTypes
                            select b;
            }

            //using (var db = new HomeAutomation.DAL.HomeAutomationEntities)
            //{
            //    var query = from b in db.DoorSwitchSensor
            //                select b;
            //}
        }

        public List<DoorSwitchDTO> GetReadings()
        {
            return DAL.DoorSwitch.GetReadings();
        }

        public void RecordReading(DoorSwitchDTO dsr)
        {
            DAL.DoorSwitch.InsertReading(dsr);
        }
    }
}
