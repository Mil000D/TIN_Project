using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;

namespace TIN_Project.Server.Controllers.Cultures
{
	[Route("api/[controller]")]
	[ApiController]
	public class CulturesController : ControllerBase
	{
        public IActionResult Set([FromQuery]string culture, [FromQuery]string redirectUri)
        {
            if (culture != null)
            {
                HttpContext.Response.Cookies.Append(
                    CookieRequestCultureProvider.DefaultCookieName,
                    CookieRequestCultureProvider.MakeCookieValue(
                        new RequestCulture(culture, culture)));
            }

            return LocalRedirect(redirectUri);
        }
    }
}
