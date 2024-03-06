namespace HouseRentingSystem.Controllers
{
    using HouseRentingSystem.Core.Contracts;
    using HouseRentingSystem.Core.Models.Agent;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    public class AgentController : BaseController
    {
        private readonly IAgentService agentService;

        public AgentController(IAgentService agentService)
        {
            this.agentService = agentService;
        }

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
