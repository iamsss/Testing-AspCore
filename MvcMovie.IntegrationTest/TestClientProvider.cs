using System.Net.Http;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using MvcMovie.mvc;

namespace MvcMovie.IntegrationTest
{
    public class TestClientProvider
    {
        private TestServer server;

        public HttpClient Client { get; private set; }

        public TestClientProvider()
        {
            server = new TestServer(new WebHostBuilder().UseStartup<Startup>());

            Client = server.CreateClient();
        }

        public void Dispose()
        {
            server?.Dispose();
            Client?.Dispose();
        }
    }
}