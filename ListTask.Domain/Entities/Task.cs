using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListTask.Domain.Entities
{
    public class Task
    {
        public Task(Guid id, string titulo, string corpo, Enum situacao, DateTime dataCreate, DateTime dataFinalizacao)
        {
            Id = Guid.NewGuid();
            Titulo = titulo;
            Corpo = corpo;
            Situacao = situacao;
            DataCreate = DateTime.Now;
            DataFinalizacao = dataFinalizacao;
        }

        public Guid Id { get; private set; }
        public string Titulo { get; private set; }
        public string Corpo { get; private set; }
        public Enum Situacao { get; private set; }
        public DateTime DataCreate { get; private set; }
        public DateTime DataFinalizacao { get; private set; }




    }
}
