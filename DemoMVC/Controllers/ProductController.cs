using Microsoft.AspNetCore.Mvc;
using DemoMVC.Data;
using DemoMVC.Models;
using System.Linq;

namespace DemoMVC.Controllers
{
    public class ProductController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ProductController(ApplicationDbContext context)
        {
            _context = context;
        }

        // READ
        public IActionResult Index()
        {
            var data = _context.Products.ToList();
            return View(data);
        }

        // CREATE GET
        public IActionResult Create()
        {
            return View();
        }

        // CREATE POST
        [HttpPost]
        public IActionResult Create(Product p)
        {
            _context.Products.Add(p);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        // EDIT GET
        public IActionResult Edit(int id)
        {
            var p = _context.Products.Find(id);
            if (p == null)
            {
                return NotFound();
            }
            return View(p);
        }

       [HttpPost]
public IActionResult Edit(Product p)
{
    if (ModelState.IsValid)
    {
        _context.Products.Update(p);
        _context.SaveChanges();
        return RedirectToAction("Index");
    }
    return View(p);
}
        // DELETE
        public IActionResult Delete(int id)
        {
            var p = _context.Products.Find(id);

            if (p != null)
            {
                _context.Products.Remove(p);
                _context.SaveChanges();
            }

            return RedirectToAction("Index");
        }
    }
}