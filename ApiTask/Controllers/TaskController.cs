using System.Collections.Generic;
using ApiTask.Models;
using Microsoft.AspNetCore.Mvc;
using Task = ApiTask.Models.Task;

namespace ApiTask.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    public class TaskController : Controller
    {
        private readonly ITaskRepository _taskRepository;
        public TaskController(ITaskRepository taskRepository)
        {
            _taskRepository = taskRepository;
        }

        [HttpGet]
        public IEnumerable<Task> GetAll()
        {
            return _taskRepository.GetAll();
        }

        [HttpGet("{id}", Name = "GetTask")]
        public IActionResult GetById(int id)
        {
            var item = _taskRepository.Find(id);
            if (item == null)
                return NotFound();

            return new ObjectResult(item);
        }

        [HttpPost]
        public IActionResult Create([FromBody] Task tarefa)
        {
            if (tarefa == null)
                return BadRequest();

            _taskRepository.Add(tarefa);
            return CreatedAtRoute("GetTask", new { id = tarefa.Id }, tarefa);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody]Task tarefaUp)
        {
            if (tarefaUp == null || tarefaUp.Id != id)
                return BadRequest();

            var tarefa = _taskRepository.Find(id);
            if (tarefa == null)
                return NotFound();

            tarefa.Titulo = tarefa.Titulo;
            tarefa.Descricao = tarefa.Descricao;
            tarefa.Status = tarefa.Status;
            _taskRepository.Update(tarefa);

            return new NoContentResult();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var todo = _taskRepository.Find(id);
            if (todo == null)
                return NotFound();

            _taskRepository.Remove(id);
            return new NoContentResult();
        }
    }
}
