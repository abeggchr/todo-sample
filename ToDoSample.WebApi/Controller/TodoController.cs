using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

using ToDoSample.WebApi.Models;

namespace ToDoSample.WebApi.Controller
{
    public class ToDoController : ApiController
    {
        private static List<ToDoItemDto> ToDoRepo = new List<ToDoItemDto>();

        [HttpPost]
        [Route("api/todos")]
        public IHttpActionResult Create([FromBody]ToDoItemDto item)
        {
            item.Id = ToDoRepo.Count + 1;

            ToDoRepo.Add(item);

            return this.Ok(item);
        }

        [HttpGet]
        [Route("api/todos")]
        public IHttpActionResult Read()
        {
            return this.Ok(ToDoRepo);
        }

        [HttpPut]
        [Route("api/todos/{itemId}")]
        public IHttpActionResult Update(int itemId, [FromBody]ToDoItemDto item)
        {
            var foundItem = ToDoRepo.FirstOrDefault(t => t.Id == itemId);

            if (foundItem != null)
            {
                foundItem.Completed = item.Completed;
                foundItem.Title = item.Title;

                return this.Ok(ToDoRepo);
            }

            return this.NotFound();
        }

        [HttpDelete]
        [Route("api/todos/{itemId}")]
        public IHttpActionResult Delete(int itemId)
        {
            var foundItem = ToDoRepo.FirstOrDefault(t => t.Id == itemId);

            if (foundItem != null)
            {
                ToDoRepo.Remove(foundItem);
                return this.Ok(ToDoRepo);
            }

            return this.NotFound();
        }
    
   
    }
}
