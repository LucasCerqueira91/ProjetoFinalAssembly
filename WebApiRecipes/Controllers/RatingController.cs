using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApiRecipe.Domain.Domain;
using WebApiRecipe.Services.Services.Implementatios;
using WebApiRecipe.Services.Services.Interfaces;

namespace WebApiRecipes.Controllers
{
    public class RatingController : Controller
    {
        private readonly IRatingService _ratingService;
        public RatingController(IRatingService ratingService)
        {
            _ratingService = ratingService;
        }
        // GET: RatingController1
        public ActionResult Index()
        {
            return View();
        }

        // GET: RatingController1/Details/5
        public IActionResult Details(int id)
        {
           var rating = _ratingService.GetById(id);
            return View(rating);
        }

        // GET: RatingController1/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: RatingController1/Create
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

        // GET: RatingController1/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: RatingController1/Edit/5
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

        // GET: RatingController1/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: RatingController1/Delete/5
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
        public IActionResult Add(Rating rating)
        {
            return View(rating);
        }
        public IActionResult Update()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Save(Rating rating)
        {
            _ratingService.Save(rating);
            return RedirectToAction("Index", "Home");
        }
    }
}
