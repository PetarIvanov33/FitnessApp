using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace FitnessApp.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/[controller]/[Action]/{id?}")]
    [Authorize(Roles = "Admin")]
    public class BaseController : Controller
    {
        
    }
}
