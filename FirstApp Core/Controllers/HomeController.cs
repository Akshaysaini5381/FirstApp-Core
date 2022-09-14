using FirstApp_Core.db;
using FirstApp_Core.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace FirstApp_Core.Controllers
{
    public class HomeController : Controller
    {
        private readonly data1 _DB ;

        public HomeController(data1 Db)
        {
            _DB = Db;
        }

        public IActionResult Index()
        {
            var res = _DB.students.ToList();
            return View(res);
        }
        public IActionResult delete(int id)
        {
            var deleteitem = _DB.students.Where(a => a.StudentId == id).First();
            _DB.students.Remove(deleteitem);
            _DB.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult add(student obj)
        {
            if (obj.StudentId==0)
            {
                _DB.students.Add(obj);
                _DB.SaveChanges();
            }
            else
            {
                _DB.students.Update(obj);
                _DB.SaveChanges();
            }

            return RedirectToAction("Index");
        }

        public IActionResult edit(int id)
        {
            var edititem = _DB.students.Where(a => a.StudentId == id).First();
            return View("add",edititem);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
