using System.Net.Http;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using MvcMovie.mvc;

namespace MvcMovie.IntegrationTest
{
    public class TestClientProvider
    {
         public HttpClient Client { get; private set; }
 
    public TestClientProvider()
    {
        var server = new TestServer(new WebHostBuilder().UseStartup<Startup>());
 
        Client =  server.CreateClient();
    }
    }
}