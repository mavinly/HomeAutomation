﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HomeAutomation.Web.Controllers
{
    public class DoorSwitchController : ApiController
    {
        // GET: api/DoorSwitch
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/DoorSwitch/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/DoorSwitch
        public void Post([FromBody] value)
        {
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