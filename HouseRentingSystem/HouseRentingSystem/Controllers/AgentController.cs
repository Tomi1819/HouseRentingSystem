namespace HouseRentingSystem.Controllers
{
    using HouseRentingSystem.Core.Models.Agent;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    [Authorize]
    public class AgentController : Controller
    {
        [HttpGet]
        public async Task<IActionResult> Become()
        {
            return View(new BecomeAgentFormModel());
        }

        [HttpPost]
        public async Task<IActionResult> Become(BecomeAgentFormModel agent)
        {
            return RedirectToAction(nameof(HouseController.All), "House");
        }
    }
}
