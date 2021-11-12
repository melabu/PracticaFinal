using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Diagnostics;

namespace WebElReyCan.Filters
{
    public class MyFilter: ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            var turnoController = filterContext.RouteData.Values["Controller"];
            var turnoAction = filterContext.RouteData.Values["Values"];
            Debug.WriteLine($"Controller: {turnoController}\nAction: {turnoAction}\n Paso por OnActionExecuting");
        }

        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            var turnoController = filterContext.RouteData.Values["Controller"];
            var turnoAction = filterContext.RouteData.Values["Values"];
            Debug.WriteLine($"Controller: {turnoController}\nAction: {turnoAction}\n Paso por OnActionExecuted");
        }
    }
}