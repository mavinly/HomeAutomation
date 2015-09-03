using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeAutomation.BusinessServices.SensorReading
{
    public enum Sensors
        {
            DoorSwitch,
            Temperature
        }
    public class SensorFactory
    {
        public ISensorItem GetSensorItem(Sensors sensorName)
        {
            return new SensorItems.DoorSwitchItem();
        }
    }
}
