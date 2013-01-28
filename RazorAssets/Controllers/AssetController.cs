using RazorAssets.Data;
using System;
using System.Web.Mvc;

namespace RazorAssets.Controllers
{
    public class AssetController : Controller
    {
        [ContentType("text/css")]
        public ActionResult Styles()
        {            
            return View(QuickStorage.Model);
        }
    }

    public class ContentType : FilterAttribute, IActionFilter
    {
        private string contentType;

        public ContentType(string ct)
        {
            this.contentType = ct;
        }

        public void OnActionExecuted(ActionExecutedContext filterContext)
        {
            return;
        }

        public void OnActionExecuting(ActionExecutingContext filterContext)
        {
            filterContext.HttpContext.Response.ContentType = this.contentType;
        }
    }
}
