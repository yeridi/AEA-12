using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DOMAIN2;
using SERVICE;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class StudentController : Controller
    {
        private StudentService service = new StudentService();

        public ActionResult IndexRazor()
        {
            var model = (from c in service.Get()
                         select new StudentModel
                         {
                             studentID = c.studentID,
                             studentAdress = c.studentAdress,
                             studentName = c.studentName,
                             studentLastName = c.studentLastName,
                             studentCode = c.studentCode
                         }).ToList();
            return View(model);
        }

        public ActionResult Index()
        {
            return View();
        }

        public JsonResult getStudent(string id)
        {
            return Json(service.Get(), JsonRequestBehavior.AllowGet);
        }

        public ActionResult createStudent(Student std)
        {
            service.Insert(std);
            string message = "Success";
            return Json(service.Get(), JsonRequestBehavior.AllowGet);
        }
    }
}