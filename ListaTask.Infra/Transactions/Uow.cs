using ListaTask.Infra.Context;

namespace ListaTask.Infra.Transactions
{
   
        public class Uow : IUow
        {
            private readonly ContextListaTask _context;

            public Uow(ContextListaTask context)
            {
                _context = context;
            }

            public void Commit()
            {
                _context.SaveChanges();
            }

            public void Rollback()
            {
                // Do nothing :)
            }
        }
    
}
