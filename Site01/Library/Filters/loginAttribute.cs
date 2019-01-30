using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Rewrite.Internal.UrlActions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Site01.Library.Filters
{
    public class LoginAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            //Verificar a session 
            if (context.HttpContext.Session.GetString("Login") == null)
            {
                context.Result = new RedirectToActionResult("Login", "Home", null);
            }


            base.OnActionExecuting(context);
        }
    }
}
