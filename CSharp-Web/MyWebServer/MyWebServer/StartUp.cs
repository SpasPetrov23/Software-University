namespace MyWebServer
{
    using MyWebServer.Server;
    using MyWebServer.Server.Responses;
    using System.Threading.Tasks;

    //localhost = 127.0.0.1 -> this is our own, local, address.

    public class StartUp
    {
        public static async Task Main()
            => await new HttpServer(routes => routes
                .MapGet("/", new TextResponse("Hello from Ivo!"))
                .MapGet("/Cats", new HtmlResponse("<h1>Hello from the cats!</h1>"))
                .MapGet("/Dogs", new HtmlResponse("<h1>Hello from the dogs!</h1>")))
            .Start();
    }
}
