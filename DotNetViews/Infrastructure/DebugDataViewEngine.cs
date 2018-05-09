using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewEngines

namespace DotNetViews.Infrastructure
{
    public class DebugDataViewEngine : IViewEngine
    {
        public ViewEngineResult GetView(string executingFilePath, string viewPath, bool isMainPage)
        {
            return ViewEngineResult.NotFound(viewPath, new string[] { "(Debug View Engine - Get View" });
        }
    }
}
