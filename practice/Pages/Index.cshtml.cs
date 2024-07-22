using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyApp.Namespace
{
  public class ProfileModel : PageModel
  {
    public void OnGet()
    {
      ViewData["myName"] = "Alex Nichols";
      ViewData["username"] = "AlexBroskee";
      ViewData["myOccupation"] = "Codecademy Student";
      ViewData["myAge"] = 31;
      ViewData["currentDate"] = "22/07/2024";
    }
  }
}