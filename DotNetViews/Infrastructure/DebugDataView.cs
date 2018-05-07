using System;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewEngines;

namespace DotNetViews.Infrastructure
{
    public class DebugDataView : IView
    {
        public string Path => String.Empty;

        public async Task RenderAsync(ViewContext context) {
            context.HttpContext.Response.ContentType = "text/plain";

            StringBuilder sb = new StringBuilder();

            sb.AppendLine("--RoutingData--");
            foreach(var kvp in context.ViewData) {
                sb.AppendLine($"Key: {kvp.Key}, Value: {kvp.Value}");
            }

            await context.Writer.WriteAsync(sb.ToString());
        }
    }
}
