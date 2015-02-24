using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace ToDoSample.WebApi
{
    public class DefaultController : ApiController
    {
        [HttpGet]
        [Route("api/version")]
        public IHttpActionResult Version()
        {
            // var versionInfo = AssemblyVersionHelper.GetVersion(this.GetType().Assembly, this.fisConfiguration.Environment);

            return this.Json("OK");
        }

    }
}
