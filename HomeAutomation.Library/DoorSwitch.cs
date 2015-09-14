﻿using System;
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
        public DoorSwitch()
        {

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
