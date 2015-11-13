using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Authorization;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Mvc;
using Microsoft.AspNet.Mvc.Rendering;
using Microsoft.Data.Entity;
using firstDotNet.Models;
using firstDotNet.Services;
using firstDotNet.ViewModels.Album;



namespace firstDotNet.Controllers
{	
	[Authorize]
	public class AlbumController : Controller
	{	
		[HttpGet]
		public IActionResult NewAlbum()
		{
			ViewData["Message"] = "Create a new AlbumController.";
			return View();
		}
		
		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> NewAlbum(NewAlbumViewModel model)
		{
			ViewData["Message"] = "Created";
			if (ModelState.IsValid)
			{
				return View("Items");
			}
			return View(model);
		}
		
		
	}
	
	
	
	
	
	
}