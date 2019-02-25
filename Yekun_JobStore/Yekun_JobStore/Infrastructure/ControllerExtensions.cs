using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Yekun_JobStore.Infrastructure
{
    public static class ControllerExtensions
    {
        public static void AddToModelErrors(this Controller controller, IEnumerable<IdentityError> errors)
        {
            foreach (IdentityError error in errors)
            {
                controller.ModelState.AddModelError("", error.Description);
            }
        }
      
    }
}
