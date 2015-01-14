using Nancy;

namespace AutoDeployToAzure
{
    public class HelloWorldModule : NancyModule
    {
        public HelloWorldModule() : base("/")
        {
            Get["/"] = HelloWorld;
        }

        private object HelloWorld(dynamic parameters)
        {
            return "Hello world!";
        }
    }
}