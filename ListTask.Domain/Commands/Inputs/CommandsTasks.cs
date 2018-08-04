﻿using ListaTask.Shared.Commads;
using System;

namespace ListTask.Domain.Commands.Inputs
{
    public class CommandsTasks : ICommand
    {        
        public string Titulo { get;  set; }
        public string Tarefa { get;  set; }
        public string Situacao { get;  set; }
        public DateTime DataCreate { get;  set; }
        public DateTime DataFinalizacao { get; set; }

    }
}
