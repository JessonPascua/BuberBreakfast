using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace BuberBreakfast.Controllers;

public class ErrorController : ControllerBase
{
    [Route("/error")]
    public IActionResult Error()
    {
        return Problem();
    } 
}