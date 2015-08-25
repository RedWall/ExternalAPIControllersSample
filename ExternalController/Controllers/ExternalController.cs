using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace ExternalController.Controllers
{
    public class ExternalValuesController : ApiController
    {
        // GET api/externalvalues
        /// <summary>
        /// Gets the list of values
        /// </summary>
        /// <returns></returns>
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/externalvalues/5
        /// <summary>
        /// Gets the specified value
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        public string Get(int id)
        {
            return "value";
        }

        // POST api/externalvalues
        /// <summary>
        /// Creates the value
        /// </summary>
        /// <param name="value">The value.</param>
        public void Post([FromBody]string value)
        {
        }

        // PUT api/externalvalues/5
        /// <summary>
        /// Creates or updates the value
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <param name="value">The value.</param>
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/externalvalues/5
        /// <summary>
        /// Deletes the value
        /// </summary>
        /// <param name="id">The identifier.</param>
        public void Delete(int id)
        {
        }
    }
}
