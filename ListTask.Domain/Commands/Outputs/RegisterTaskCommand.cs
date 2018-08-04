using ListaTask.Shared.Commads;
using System;

namespace ListTask.Domain.Commands.Outputs
{
    public class RegisterTaskCommand: ICommandResult

    {
        public RegisterTaskCommand()
        {

        }

        public RegisterTaskCommand(Guid id, string titulo)
        {
            Id = id;
            Titulo = titulo;
        }

        public Guid Id { get; set; }
        public string Titulo { get; set; }
    }
}
