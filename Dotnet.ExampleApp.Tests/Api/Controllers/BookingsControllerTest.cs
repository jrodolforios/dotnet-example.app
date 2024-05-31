using Moq;
using NUnit.Framework;

namespace Dotnet.ExampleApp.Tests.Api.Controllers
{
    internal class BookingsControllerTest
    {

        [SetUp]
        public void SetUp()
        {
            _ = CreateControllerInstance();
        }

        public async Task CreateControllerInstance()
        {
        }
    }
}
