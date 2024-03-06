namespace HouseRentingSystem.Controllers
{
    using HouseRentingSystem.Core.Contracts;
    using HouseRentingSystem.Models;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using System.Diagnostics;

    public class HomeController : BaseController
    {
        private readonly ILogger<HomeController> logger;
        private readonly IHouseService houseService;

        public HomeController(
            ILogger<HomeController> logger,
            IHouseService houseService)
        {
            this.logger = logger;
            this.houseService = houseService;
        }

        [AllowAnonymous]
        public async Task<IActionResult> Index()
        {
            var model = await houseService.LastThreeHousesAsync();

            return View(model);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
