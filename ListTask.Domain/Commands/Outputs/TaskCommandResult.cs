using ListaTask.Shared.Commads;
using System;
namespace ListTask.Domain.Commands.Outputs
{
    public class TaskCommandResult: ICommand
    {
        public string Titulo { get; set; }
        public string Corpo { get; set; }
        public string Situacao { get; set; }
        public DateTime DataCreate { get; set; }
        public DateTime DataFinalizacao { get; set; }
    }
}

