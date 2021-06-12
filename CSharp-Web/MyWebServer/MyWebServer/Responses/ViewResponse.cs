namespace MyWebServer.Responses
{
    using MyWebServer.Http;
    using System.IO;
    using System.Linq;

    public class ViewResponse : HttpResponse
    {
        private const char PathSeparator = '/';
        public ViewResponse(string viewName, string controllerName, object model) 
            : base(HttpStatusCode.OK)
            => this.GetHtml(viewName, controllerName, model);

        private void GetHtml(string viewName, string controllerName, object model)
        {
            if (!viewName.Contains(PathSeparator))
            {
                viewName = controllerName + PathSeparator + viewName;
            }

            var viewPath = Path.GetFullPath($"./Views/" + viewName.TrimStart(PathSeparator) + ".cshtml");

            if (!File.Exists(viewPath))
            {
                this.PrepareMissingViewError(viewPath);
                return;
            }

            var viewConent = File.ReadAllText(viewPath);

            if (model != null)
            {
                viewConent = this.PopulateModel(viewConent, model);
            }

            this.PrepareContent(viewConent, HttpContentType.Html);
        }

        private void PrepareMissingViewError(string viewPath)
        {
            this.StatusCode = HttpStatusCode.NotFound;

            var errorMessage = $"View '{viewPath}' was not found.";

            this.PrepareContent(errorMessage, HttpContentType.PlainText);
        }

        private string PopulateModel(string viewContent, object model)
        {
            var data = model
                .GetType()
                .GetProperties()
                .Select(pr => new
                {
                    Name = pr.Name,
                    Value = pr.GetValue(model)
                });

            foreach (var entry in data)
            {
                const string openingBrackets = "{{";
                const string closingBrackers = "}}";
                viewContent = viewContent.Replace($"{openingBrackets}{entry.Name}{closingBrackers}", entry.Value.ToString());
            }

            return viewContent;
        }
    }
}
