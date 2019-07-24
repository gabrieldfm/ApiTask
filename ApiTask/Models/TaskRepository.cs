using System.Collections.Generic;
using System.Linq;

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
            return _context.Tasks.ToList();
        }

        public void Add(Task tarefa)
        {
            _context.Tasks.Add(tarefa);
            _context.SaveChanges();
        }

        public Task Find(int id)
        {
            return _context.Tasks.FirstOrDefault(t => t.Id == id);
        }

        public void Remove(int id)
        {
            var entity = _context.Tasks.First(t => t.Id == id);
            _context.Tasks.Remove(entity);
            _context.SaveChanges();
        }

        public void Update(Task tarefa)
        {
            _context.Tasks.Update(tarefa);
            _context.SaveChanges();
        }
    }
}
