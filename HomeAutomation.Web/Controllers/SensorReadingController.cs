using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using HomeAutomation.BusinessServices.SensorReading;

namespace HomeAutomation.Web.Controllers
{
    public class SensorReadingController : ApiController
    {
        ISensorReading _SensorReading;
        public SensorReadingController(ISensorReading sr)
        {
            _SensorReading = sr;
        }

        // GET: api/SensorReading
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/SensorReading/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/SensorReading
        public void Post([FromBody]string value)
        {
            _SensorReading.RecieveSensorReading(value);
        }

        // PUT: api/SensorReading/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/SensorReading/5
        public void Delete(int id)
        {
        }
    }
}
