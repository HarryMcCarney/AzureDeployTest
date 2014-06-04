using Nancy;

namespace AzureDeployTest.Api
{
    public class HomeModule :NancyModule
    {
        public HomeModule()
        {
            Get["/"] = _ => "Hello world";

        }
    }
}