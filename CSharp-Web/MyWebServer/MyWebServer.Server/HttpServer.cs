namespace MyWebServer.Server
{
    using System;
    using System.Net;
    using System.Net.Sockets;
    using System.Text;
    using System.Threading.Tasks;
    using MyWebServer.Server.Http;
    using MyWebServer.Server.Routing;

    public class HttpServer
    {
        private readonly IPAddress ipAddress;
        private readonly int port;
        private readonly TcpListener listener;

        public HttpServer(string ipAddress, int port, Action<IRoutingTable> routingTable)
        {
            //Allows the browser to connect to my webserver when working with localhost.
            this.ipAddress = IPAddress.Parse(ipAddress);
            this.port = port;

            listener = new TcpListener(this.ipAddress, this.port);
        }

        public HttpServer(int port, Action<IRoutingTable> routingTable)
            : this("127.0.0.1", port, routingTable)
        {
        }
        public HttpServer(Action<IRoutingTable> routingTable) 
            : this(5000, routingTable)
        {

        }

        public async Task Start()
        {

            this.listener.Start();

            Console.WriteLine($"Server started on port {port}...");
            Console.WriteLine($"Awaiting requests...");

            //The while(true) loop allows for the Server to receive multiple requests without closing down.
            while (true)
            {
                //The Async method here allows for multiple people to connect to the server without waiting for eachother.
                var connection = await this.listener.AcceptTcpClientAsync();

                //The stream allows for a stream of bytes to be sent (.Write()) or received (.Read()) to the browser.
                var networkStream = connection.GetStream();

                var requestText = await this.ReadRequest(networkStream);

                Console.WriteLine(requestText);

                // var request = HttpRequest.Parse(requestText);

                await WriteResponse(networkStream);

                connection.Close();
            }
        }

        private async Task<string> ReadRequest(NetworkStream networkStream)
        {
            //The Request is stored in chunks of 1024 bytes and stored in a StringBuilder.
            var bufferLength = 1024;
            var buffer = new byte[bufferLength];

            var totalBytes = 0;

            var requestBuilder = new StringBuilder();

            do
            {
                var bytesRead = await networkStream.ReadAsync(buffer, 0, bufferLength);

                totalBytes += bytesRead;

                if (totalBytes > 10 * 1024)
                {
                    throw new InvalidOperationException("Request is too large.");
                }

                requestBuilder.Append(Encoding.UTF8.GetString(buffer, 0, bytesRead));
            }
            while (networkStream.DataAvailable);

            return requestBuilder.ToString();
        }

        private async Task WriteResponse(NetworkStream networkStream)
        {
            var content = @"
<html>
    <head>
        <link = rel=""icon"" href=""data:,"">
    </head>
    <body>
        Hello from my server!
    </body>
</html>";
            var contentLength = Encoding.UTF8.GetByteCount(content);

            var response = $@"
HTTP/1.1 200 OK
Server: My Web Server
Date: {DateTime.UtcNow.ToString("r")}
Content-Length: {contentLength}
Content-Type: text/html; charset=UTF-8

{content}";

            var responseBytes = Encoding.UTF8.GetBytes(response);
            //Sends the response as bytes[] towards the server.
            await networkStream.WriteAsync(responseBytes);
        }
    }
}
