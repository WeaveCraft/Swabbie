using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;

namespace Swabbie_Server
{
    [Route("/[controller]")]
    [ApiController]
    public class Culture : ControllerBase
    {
        public ActionResult SetCulture()
        {
            IRequestCultureFeature culture = HttpContext.Features.Get<IRequestCultureFeature>();
            Response.Cookies.Append(
                CookieRequestCultureProvider.DefaultCookieName,
                CookieRequestCultureProvider.MakeCookieValue(new RequestCulture((new string[] { "en-US", "es-ES", "sv-SE" }.Where(s => s != culture.RequestCulture.Culture.Name).FirstOrDefault()))));
            return Redirect("/");
        }
    }
}
