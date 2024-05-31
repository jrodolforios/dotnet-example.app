using Dotnet.ExampleApp.Infra.Context;
using Dotnet.ExampleApp.Infra.Repositories.CarRepo;

namespace Dotnet.ExampleApp.Infra.Repositories
{
    public interface IUnitOfWork : IDisposable
    {
        public ICarRepository Cars { get; }

        ModelContext getContext();
    }
}
