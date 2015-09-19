using HomeAutomation.Model.DoorSwitchReading;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeAutomation.DAL;

namespace HomeAutomation.DAL.DoorSwitch
{
    public class DoorSwitch
    {
        static List<DoorSwitchDTO>  _doorSwitchItems;

        static DoorSwitch _instance;
        public static DoorSwitch Singleton()
        {
            if (_instance == null)
            {
                _instance = new DoorSwitch();
            }

            if (_doorSwitchItems == null)
            {
                _doorSwitchItems = new List<DoorSwitchDTO>();
            }
            return _instance;
        }
                   
        private DoorSwitch()
        {

        }
        public List<DoorSwitchDTO> GetReadings()
        {
            return _doorSwitchItems;
            //using (var db = new HomeAutomation.DAL.HomeAutomationEntities())
            //{
            //    var query = (from item in db.SensorReadings
            //                 join dss in db.DoorSwitchSensors on item.Id equals dss.SensorReadingID
            //                 join sr in db.Sensors on item.SensorID equals sr.Id 
            //                 select (new DoorSwitchDTO { ReadingDateTime = item.ReadingDateTime })).ToList();

            //    return query;
            //}
        }

        public void InsertReading(DoorSwitchDTO item)
        {
            _doorSwitchItems.Add(item);
        }
    }
}
