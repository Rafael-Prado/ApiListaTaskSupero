using ListTask.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace ListaTask.Infra.Mappings
{
    public class TaskMap : EntityTypeConfiguration<Task>
    {
        public TaskMap()
        {
            ToTable("Task");
            HasKey(x => x.Id);
            Property(x => x.DataCreate);
            Property(x => x.DataFinalizacao).IsOptional();
            Property(x => x.Titulo).IsRequired().HasMaxLength(150);
            Property(x => x.Corpo).IsRequired().HasMaxLength(400);
            Property(x => x.Situacao).IsRequired();
        }
    }
}
