using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Razor;


namespace DotNetViews.Infrastructure
{
    public class ColorExpander : IViewLocationExpander
    {
        private static Dictionary<string, string> Colors
            = new Dictionary<string, string>
            {
                ["red"] = "Red",
                ["green"] = "Green",
                ["blue"] = "Blue"
            };
        public void PopulateValues(ViewLocationExpanderContext context)
        {
            var routeValues = context.ActionContext.RouteData.Values;
            string color;
            if (routeValues.ContainsKey("id")
                    && Colors.TryGetValue(routeValues["id"] as string, out color)
                    && !string.IsNullOrEmpty(color)) {
                context.Values["color"] = color;
            }
        }
    }
}
