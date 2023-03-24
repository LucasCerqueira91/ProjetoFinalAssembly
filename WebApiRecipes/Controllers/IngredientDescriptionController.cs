using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApiRecipe.Domain.Domain;
using WebApiRecipe.Domain.Entities;
using WebApiRecipe.Services.Services.Implementatios;
using WebApiRecipe.Services.Services.Interfaces;

namespace WebApiRecipes.Controllers
{
    public class IngredientDescriptionController : Controller
    {
        // GET: IngredientDescriptionController

        private readonly IIngredientDescriptionService _ingredientDescription;
        public IngredientDescriptionController(IIngredientDescriptionService ingredientDescriptionService)
        {
            _ingredientDescription = ingredientDescriptionService;
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
        public IActionResult Save(IngredientDescription ingredientDescriptionService)
        {
            _ingredientDescription.Save(ingredientDescriptionService);
            return RedirectToAction("Index", "Home");
        }

        // GET: IngredientDescriptionController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: IngredientDescriptionController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: IngredientDescriptionController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: IngredientDescriptionController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: IngredientDescriptionController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: IngredientDescriptionController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: IngredientDescriptionController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
