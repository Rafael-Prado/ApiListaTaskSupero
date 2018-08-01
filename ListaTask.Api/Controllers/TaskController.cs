using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Http;
using ListaTask.Api.Service;
using ListTask.Domain.Entities;
using Swashbuckle.Swagger.Annotations;

namespace ListaTask.Api.Controllers
{
    [RoutePrefix("task/api")]
    public class TaskController : ApiController
    {
        private readonly ITaskServece _taskService;

        public TaskController(ITaskServece taskService)
        {
            _taskService = taskService;
        }

        [HttpGet]
        [Route("")]
        [SwaggerOperation("GetAll")]
        public IHttpActionResult GetAll()
        {
            var tasks = _taskService.GetAll();
            return Ok(tasks);
        }

        [HttpGet]
        [Route("{id}")]
        [SwaggerOperation("GetById")]
        [SwaggerResponse(HttpStatusCode.OK)]
        [SwaggerResponse(HttpStatusCode.NotFound)]
        public IHttpActionResult GetTaskId(Guid id)
        {
            
            if (id != null)
            {
               var task = _taskService.GetTaskId(id);
                return Ok(task);
            }

            return NotFound();

        }

        // POST api/
        [HttpPost]
        [Route("")]
        [SwaggerOperation("Create")]
        [SwaggerResponse(HttpStatusCode.Created)]
        public IHttpActionResult SalveTask([FromBody] Task task)
        {
             

            if (task != null)
            {
                _taskService.save(task);

                return Ok();
            }

            return NotFound();

        }

        // PUT api/values/5
        [SwaggerOperation("Update")]
        [SwaggerResponse(HttpStatusCode.OK)]
        [SwaggerResponse(HttpStatusCode.NotFound)]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [SwaggerOperation("Delete")]
        [SwaggerResponse(HttpStatusCode.OK)]
        [SwaggerResponse(HttpStatusCode.NotFound)]
        public void Delete(int id)
        {
        }
    }
}
