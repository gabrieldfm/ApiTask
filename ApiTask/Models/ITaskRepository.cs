using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiTask.Models
{
    public interface ITaskRepository
    {
        void Add(Task tarefa);
        IEnumerable<Task> GetAll();
        Task Find(int id);
        void Remove(int id);
        void Update(Task tarefa);
    }
}
