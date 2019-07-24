using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiTask.Models
{
    public class Task
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public char Status { get; set; }
        public string Descricao { get; set; }
    }
}
