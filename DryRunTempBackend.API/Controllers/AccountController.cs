using DryRunTempBackend.API.Proxies;
using Microsoft.AspNetCore.Mvc;

namespace DryRunTempBackend.API.Controllers
{
    [Route("api/Account")]
    public class AccountController : Controller
    {
        [HttpPost]
        public ObjectResult Signup([FromBody] Signup model)
        {
            return Ok(model.Surname);
        }
    }
}