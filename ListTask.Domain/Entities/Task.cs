using System;

namespace ListTask.Domain.Entities
{
    public class Task
    {
        public Task(string titulo, string corpo, string situacao, DateTime? dataFinalizacao)
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
        public string Situacao { get; private set; }
        public DateTime DataCreate { get; private set; }
        public DateTime? DataFinalizacao { get; private set; }




    }
}
