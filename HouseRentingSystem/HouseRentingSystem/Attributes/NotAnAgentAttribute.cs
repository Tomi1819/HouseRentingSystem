namespace HouseRentingSystem.Attributes
{
    using HouseRentingSystem.Core.Contracts;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Filters;
    using System.Security.Claims;

    public class NotAnAgentAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            base.OnActionExecuting(context);

            IAgentService? agentService = context.HttpContext.RequestServices.GetService<IAgentService>();

            if (agentService is null)
            {
                context.Result = new StatusCodeResult(StatusCodes.Status500InternalServerError);
            }

            if (agentService is not null && 
                agentService.ExistsByIdAsync(context.HttpContext.User.Id()).Result)
            {
                context.Result = new StatusCodeResult(StatusCodes.Status400BadRequest);
            }

        }
    }
}
