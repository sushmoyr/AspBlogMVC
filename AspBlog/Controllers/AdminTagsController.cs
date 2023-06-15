using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspBlog.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace AspBlog.Controllers;

public class AdminTagsController : Controller
{
    [HttpGet]
    public IActionResult Add()
    {
        return View();
    }

    [HttpPost]
    [ActionName("Add")]
    public IActionResult SubmitTag(AddTagRequest addTagRequest)
    {
        var name = addTagRequest.Name;
        var displayName = addTagRequest.DisplayName;
        
        Console.WriteLine(name);
        Console.WriteLine(displayName);
        return View("Add");
    }
}