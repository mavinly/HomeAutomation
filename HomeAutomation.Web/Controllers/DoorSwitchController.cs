using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using HomeAutomation.BusinessServices;

namespace HomeAutomation.Web.Controllers
{
    public class DoorSwitchController : ApiController
    {
        IDoorSwitch _doorSwitch;
        public DoorSwitchController(IDoorSwitch doorSwitch)
        {
            _doorSwitch = doorSwitch;
        }
        // GET: api/DoorSwitch
        public IEnumerable<DoorSwitchReading> Get()
        {
            return new DoorSwitchReading[] { new DoorSwitchReading { ID = 1 } };
        }

        // GET: api/DoorSwitch/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/DoorSwitch
        public void Post([FromBody]DoorSwitchReading value)
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
