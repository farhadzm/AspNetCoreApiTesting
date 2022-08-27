using FluentAssertions;
using Microsoft.AspNetCore.Mvc.Testing;
using System.Net;
using System.Threading.Tasks;
using Xunit;

namespace XUnitIntegrationTest.WebApplication.Test.IntegraionTests
{
    public class UsersControllerTest : IClassFixture<WebApplicationFactory<Startup>>
    {
        private readonly WebApplicationFactory<Startup> _factory;

        public UsersControllerTest(WebApplicationFactory<Startup> factory)
        {
            _factory = factory;
        }

        [Fact]
        public async Task When_IdIsNotValid_Then_NotFoundStatusCodeShouldBeReturned()
        {
            var httpClient = _factory.CreateClient();

            var userResponse = await httpClient.GetAsync($"/api/users/{-1}");

            userResponse.StatusCode.Should().Be(HttpStatusCode.NotFound);
        }
    }
}
