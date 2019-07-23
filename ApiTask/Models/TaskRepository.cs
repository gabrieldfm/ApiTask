using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiTask.Models
{
    public class TaskRepository:ITaskRepository
    {
        private readonly ApiContext _context;

        public TaskRepository(ApiContext context)
        {
            _context = context;
        }

        public IEnumerable<Task> GetAll()
        {
            return _context.Task.ToList();
        }

        public void Add(Task tarefa)
        {
            _context.Task.Add(tarefa);
            _context.SaveChanges();
        }

        public Task Find(int id)
        {
            return _context.Task.FirstOrDefault(t => t.Id == id);
        }

        public void Remove(int id)
        {
            var entity = _context.Task.First(t => t.Id == id);
            _context.Task.Remove(entity);
            _context.SaveChanges();
        }

        public void Update(Task tarefa)
        {
            _context.Task.Update(tarefa);
            _context.SaveChanges();
        }
    }
}
