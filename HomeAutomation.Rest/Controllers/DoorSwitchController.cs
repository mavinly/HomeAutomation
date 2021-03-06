﻿using HomeAutomation.BusinessServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using HomeAutomation.Model.DoorSwitchReading;

namespace HomeAutomation.Rest.Controllers
{
    public class DoorSwitchController : ApiController
    {
        private IDoorSwitch _doorSwitch;

        public DoorSwitchController(IDoorSwitch doorSwitch)
        {
            _doorSwitch = doorSwitch;
        }

        public DoorSwitchController()
        {
            _doorSwitch = new BusinessServices.DoorSwitch();
        }
        // GET: api/DoorSwitch
        public IEnumerable<DoorSwitchDTO> Get()
        {
            return _doorSwitch.GetReadings();
        }

        // GET: api/DoorSwitch/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/DoorSwitch
        public void Post([FromBody]DoorSwitchDTO value)
        {
            _doorSwitch.RecordReading(value);
        }

        // PUT: api/DoorSwitch/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/DoorSwitch/5
        public void Delete(int id)
        {
        }
    }
}
