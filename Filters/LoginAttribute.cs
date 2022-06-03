using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace Enoca.NET_Challenge.Filters
{
    public class LoginAttribute: ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            var kullaniciadi = context.HttpContext.Session.GetString("KullaniciAdi");
            if (string.IsNullOrEmpty(kullaniciadi))
            {
                context.Result = new RedirectToActionResult("Index", "Home", new { area = "" });
            }
        }
    }
}
