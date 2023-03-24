using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApiRecipe.Domain.Domain;
using WebApiRecipe.Domain.Entities;
using WebApiRecipe.Services.Services.Implementatios;
using WebApiRecipe.Services.Services.Interfaces;

namespace WebApiRecipes.Controllers
{
    public class IngredientUnitMeasurementController : Controller
    {
        private readonly IIngredientUnitMeasurementService _ingredientUnitMeasurementService;
        public IngredientUnitMeasurementController(IIngredientUnitMeasurementService ingredientUnitMeasurementService)
        {
            _ingredientUnitMeasurementService = ingredientUnitMeasurementService;
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
        public IActionResult Save(IngredientUnitMeasurement ingredientUnitMeasurementService)
        {
            _ingredientUnitMeasurementService.Save(ingredientUnitMeasurementService);
            return RedirectToAction("Index", "Home");
        }
        // GET: IngredientUnitMeasurementController
        public ActionResult Index()
        {
            return View();
        }

        // GET: IngredientUnitMeasurementController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: IngredientUnitMeasurementController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: IngredientUnitMeasurementController/Create
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

        // GET: IngredientUnitMeasurementController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: IngredientUnitMeasurementController/Edit/5
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

        // GET: IngredientUnitMeasurementController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: IngredientUnitMeasurementController/Delete/5
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
