﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeAutomation.BusinessServices.SensorReading
{
    public interface ISensorItem
    {
        void ProcessString(string reading);
    }
}
