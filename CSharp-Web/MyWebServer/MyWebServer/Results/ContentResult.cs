namespace MyWebServer.Results
{
    using System.Text;
    using MyWebServer.Common;
    using MyWebServer.Http;

    public class ContentResult : ActionResult
    {
        public ContentResult(
            HttpResponse response,
            string content,
            string contentType)
            : base(response)
            => this.PrepareContent(content, contentType);
    }
}
