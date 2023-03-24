using Microsoft.AspNetCore.Mvc;
using WebApiRecipe.Domain.Domain;
using WebApiRecipe.Services.Services.Implementatios;
using WebApiRecipe.Services.Services.Interfaces;

namespace WebApiRecipes.Controllers
{
    public class RecipeFavoriteController : Controller
    {
        private readonly IRecipeFavoriteService _recipeFavioriteService;
        public RecipeFavoriteController(IRecipeFavoriteService recipeFavoriteService)
        {
            _recipeFavioriteService = recipeFavoriteService;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Add()
        {
            return View();
        }
        public IActionResult Update()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Save(RecipeFavorite recipeFavoriteService)
        {
            _recipeFavioriteService.Save(recipeFavoriteService);
            return RedirectToAction("Index", "Home");
        }
    }
}
