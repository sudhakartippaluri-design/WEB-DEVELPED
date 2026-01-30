using Microsoft.AspNetCore.Mvc;
using WebApplication18.Models;
using WebApplication18.Models.Data;

namespace WebApplication18.Controllers
{
    public class UserController1 : Controller
    {

        private readonly StudentDbContext _context;

        public UserController1(StudentDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult Index()
        {
            var data = _context.userinfos.ToList();
            return View(data);
        }
        [HttpGet]
        public IActionResult Create()
        {

            return View();
        }
        [HttpPost]
        public IActionResult Create(Userinfo s)
        {
            if (ModelState.IsValid)
            {
                _context.userinfos.Add(s);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(s);
        }
        [HttpGet]

        public IActionResult Edit(int id)
        {

            var data = _context.userinfos.FirstOrDefault(x => x.UserId == id);
            if (data == null)
                return NotFound();

            return View(data);
        }

        [HttpPost]
        public IActionResult Edit(Userinfo s)
        {

            if (ModelState.IsValid)
            {
                _context.userinfos.Update(s);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(s);

        }
        [HttpGet]

        public IActionResult Deatils(int id)
        {
           var data= _context.userinfos.FirstOrDefault(x=>x.UserId == id);
            if(data == null)
            {
                return NotFound();
            }
            return View(data);
        }

        [HttpGet]

        public IActionResult Delete(int id)
        {
            var data = _context.userinfos.FirstOrDefault(x => x.UserId == id);
            if (data == null)
            {
                return NotFound();
            }
            return View(data);
        }

        [HttpPost, ActionName("Delete")]

      

        public IActionResult DeleteConfirmed(int id)
        {
            var data = _context.userinfos.FirstOrDefault(x => x.UserId == id);
          if(data!=null)
            {
                _context.userinfos.Remove(data);
                _context.SaveChanges();
               
            }
            return RedirectToAction("Index");
        }
    }
}
