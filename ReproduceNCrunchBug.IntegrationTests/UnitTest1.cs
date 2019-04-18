using System;
using Microsoft.AspNetCore.Mvc.Testing;
using Xunit;

namespace ReproduceNCrunchBug.IntegrationTests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var factory = new WebApplicationFactory<Startup>();

            factory.CreateClient();
            var server = factory.Server;

            Assert.NotNull(server);
        }

        [Fact]
        public void ContentRootEnvironmentVariableIsCreatedBasedOnProjectName()
        {
#if NCRUNCH
            var envVar = Environment.GetEnvironmentVariable("ASPNETCORE_TEST_CONTENTROOT_REPRODUCENCRUNCHBUG");
            Assert.NotNull(envVar);
#endif
        }

        [Fact]
        public void ButShouldBeOnAssemblyName()
        {
#if NCRUNCH
            var envVar = Environment.GetEnvironmentVariable("ASPNETCORE_TEST_CONTENTROOT_MYCOMPANY_REPRODUCENCRUNCHBUG");
            Assert.NotNull(envVar);
#endif
        }
    }
}
