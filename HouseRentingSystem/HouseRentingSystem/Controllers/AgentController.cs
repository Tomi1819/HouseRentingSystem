﻿namespace HouseRentingSystem.Controllers
{
    using HouseRentingSystem.Attributes;
    using HouseRentingSystem.Core.Contracts;
    using HouseRentingSystem.Core.Models.Agent;
    using Microsoft.AspNetCore.Mvc;
    using System.Security.Claims;
    using static HouseRentingSystem.Core.Constants.MessageConstants;

    public class AgentController : BaseController
    {
        private readonly IAgentService agentService;

        public AgentController(IAgentService agentService)
        {
            this.agentService = agentService;
        }

        [HttpGet]
        [NotAnAgent]
        public IActionResult Become()
        {
            return View(new BecomeAgentFormModel());
        }

        [HttpPost]
        [NotAnAgent]
        public async Task<IActionResult> Become(BecomeAgentFormModel model)
        {
            if (await agentService.UserWithPhoneNumberExistsAsync(User.Id()))
            {
                ModelState.AddModelError(nameof(model.PhoneNumber), PhoneExists);
            }

            if (await agentService.UserHasRents(User.Id()))
            {
                ModelState.AddModelError("Error", HasRents);
            }

            if (ModelState.IsValid is false)
            {
                return View(model);
            }

            await agentService.CreateAsync(User.Id(), model.PhoneNumber);

            return RedirectToAction(nameof(HouseController.All), "House");
        }
    }
}
