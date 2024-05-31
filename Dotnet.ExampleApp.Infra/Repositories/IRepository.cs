using Dotnet.ExampleApp.Infra.Context;

namespace Dotnet.ExampleApp.Infra.Repositories
{
    public interface IRepository
    {
        ModelContext getContext();
    }
}
