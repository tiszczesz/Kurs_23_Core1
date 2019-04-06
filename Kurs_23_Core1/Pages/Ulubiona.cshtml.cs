using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Kurs_23_Core1.Pages
{
    public class UlubionaModel : PageModel
    {
        public void OnGet()
        {
            ViewData["text"] = "kocham moją ....";
        }
    }
}