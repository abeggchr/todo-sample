using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace ToDoSample.WebApi
{
    public class TodoController : ApiController
    {
        [HttpGet]
        [Route("api/todos")]
        public IHttpActionResult GetAll()
        {
            // var versionInfo = AssemblyVersionHelper.GetVersion(this.GetType().Assembly, this.fisConfiguration.Environment);

            var todos = new List<ToDoItem>();

            todos.Add(new ToDoItem() { Id = 73736787, Completed = false, Title = "First ToDo" });
            todos.Add(new ToDoItem() { Id = 39474535, Completed = false, Title = "Second ToDo" });
            todos.Add(new ToDoItem() { Id = 93798798, Completed = false, Title = "Third ToDo" });

            return this.Ok(todos);
        }


    }
}
