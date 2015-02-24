using System.Collections.Generic;
using System.Web.Http;

using ToDoSample.WebApi.Models;

namespace ToDoSample.WebApi.Controller
{
    public class TodoController : ApiController
    {
        private static List<ToDoItemDto> ToDoRepo = new List<ToDoItemDto>();

        [HttpGet]
        [Route("api/todos")]
        public IHttpActionResult GetAll()
        {
            var todos = new List<ToDoItemDto>();

            todos.Add(new ToDoItemDto() { Id = 73736787, Completed = false, Title = "First ToDo" });
            todos.Add(new ToDoItemDto() { Id = 39474535, Completed = false, Title = "Second ToDo" });
            todos.Add(new ToDoItemDto() { Id = 93798798, Completed = false, Title = "Third ToDo" });

            return this.Ok(ToDoRepo);
        }


    }
}
