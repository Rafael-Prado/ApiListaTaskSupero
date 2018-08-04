using System;
using System.Net;
using System.Web.Http;
using System.Web.Http.Cors;
using ListaTask.Api.Service;
using ListaTask.Infra.Transactions;
using ListTask.Domain.Commands.Inputs;
using Swashbuckle.Swagger.Annotations;

namespace ListaTask.Api.Controllers
{
    
    [RoutePrefix("task/api")]
    public class TaskController : ApiController
    {
        private readonly ITaskServece _taskService;
        private readonly IUow _uow;

        public TaskController(ITaskServece taskService, IUow uow)
        {
            _taskService = taskService;
            _uow = uow;
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

        [HttpGet]
        [Route("situacao/{situacao}")]
        [SwaggerOperation("GetBySituacao")]
        [SwaggerResponse(HttpStatusCode.OK)]
        [SwaggerResponse(HttpStatusCode.NotFound)]
        public IHttpActionResult GetTaskSituacao(int situacao)
        {

            if (situacao != null)
            {
                var tasks = _taskService.GetTaskSituacao(situacao);
                return Ok(tasks);
            }

            return NotFound();

        }

        // POST api/
        [HttpPost]
        [Route("")]
        [SwaggerOperation("Create")]
        [SwaggerResponse(HttpStatusCode.Created)]
        public IHttpActionResult SalveTask([FromBody] CommandsTasks commands)
        {
             

            if (commands != null)
            {
                var result = _taskService.save(commands);
                _uow.Commit();
                return Ok(new
                {
                    success = true,
                    data = result
                });
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
