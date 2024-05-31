using Dotnet.ExampleApp.Infra.Context;

namespace Dotnet.ExampleApp.Infra.Repositories
{
    public class Repository : IRepository
    {
        private readonly ModelContext _context;

        public Repository(ModelContext context)
        {
            _context = context;
        }

        public ModelContext getContext()
        {
            return _context;
        }
    }
}
