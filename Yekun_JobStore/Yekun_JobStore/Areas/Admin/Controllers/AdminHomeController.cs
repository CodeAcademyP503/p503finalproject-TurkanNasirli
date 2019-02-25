using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Yekun_JobStore.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin,sUser,aUser")]
    public class AdminHomeController : Controller
    {

        [HttpGet]
        public ActionResult AdminIndex()
        {
            return View();
        }
    }
}