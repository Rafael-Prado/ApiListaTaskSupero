

using ListaTask.Shared.Commads;
using ListTask.Domain.Commands.Inputs;
using ListTask.Domain.Commands.Outputs;
using ListTask.Domain.Entities;
using ListTask.Domain.Repository.Interface;

namespace ListTask.Domain.Commands.Handlers
{
    public class TaskCommandHandler : ICommandHandler<CommandsTasks>
    {
        private readonly ITaskInterfaceRepository _taskInterfaceRepository;

        public TaskCommandHandler(ITaskInterfaceRepository taskInterfaceRepository)
        {
            _taskInterfaceRepository = taskInterfaceRepository;
        }

        public ICommandResult Handle(CommandsTasks command)
        {
            if (command != null)
            {
                var titulo = command.Titulo;
                var corpo = command.Corpo;
                var dataCreate = command.DataCreate;
                var dataFim = command.DataFinalizacao;
                var situacao = command.Situacao;    

                var task = new Task(titulo, corpo, situacao, null);

                _taskInterfaceRepository.Save(task);

                return new TaskCommandResult(task.Id, task.Titulo.ToString());
            }

            return null;

        }
        
    }
}
