using ListaTask.Shared.Commads;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListTask.Domain.Commands.Outputs
{
    public class TaskCommandResult: ICommandResult
    {
        public TaskCommandResult()
        {

        }

        public TaskCommandResult(Guid id, string titulo)
        {
            Id = id;
            Titulo = titulo;
        }

        public Guid Id { get; set; }
        public string Titulo { get; set; }
    }
}

