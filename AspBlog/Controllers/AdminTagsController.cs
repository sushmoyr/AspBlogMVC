using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AspBlog.Controllers;

public class AdminTagsController : Controller
{
    [HttpGet]
    public IActionResult Add()
    {
        return View();
    }
}