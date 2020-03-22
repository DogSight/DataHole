using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DataHole.Pages.Users
{
    public class JohnnyRocketModel : PageModel
    {
        public void OnGet()
        {
            Thread.Sleep(2000);
        }
    }
}
