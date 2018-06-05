using System;
using System.Net;
using System.Threading.Tasks;
using FluentAssertions;
using Xunit;

namespace MvcMovie.IntegrationTest
{
    public class UnitTest1
    {
        [Fact]
        public async Task Test_Get_All()
        {

            using (var client = new TestClientProvider().Client)
            {
                var response = await client.GetAsync("/api/home");

                response.EnsureSuccessStatusCode();

                response.StatusCode.Should().Be(HttpStatusCode.OK);
            }
        }

        
    }
}
