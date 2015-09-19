﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeAutomation.DAL.DoorSwitch;
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
            DAL.DoorSwitch.DoorSwitch ds = new DAL.DoorSwitch.DoorSwitch();
            return ds.GetReadings();
        }

        public void RecordReading(DoorSwitchDTO dsr)
        {
            DAL.DoorSwitch.DoorSwitch ds = new DAL.DoorSwitch.DoorSwitch();
            ds.InsertReading(dsr);
        }
    }
}
