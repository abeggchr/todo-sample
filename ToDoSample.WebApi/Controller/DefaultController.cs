using System.Web.Http;

using ToDoSample.WebApi.Properties;

namespace ToDoSample.WebApi.Controller
{
    /// <summary>
    /// The default controller.
    /// </summary>
    public class DefaultController : ApiController
    {
        /// <summary>
        /// The version.
        /// </summary>
        /// <returns>
        /// The <see cref="IHttpActionResult"/>.
        /// </returns>
        [HttpGet]
        [Route("api/version")]
        public IHttpActionResult Version()
        {
            var versionInfo = AssemblyVersionHelper.GetVersion(this.GetType().Assembly, Settings.Default.Environment);

            return this.Ok(versionInfo);
        }

    }
}
