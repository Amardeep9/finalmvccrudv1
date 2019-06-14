using PracticingCrud.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PracticingCrud.Controllers
{
    public class StudentController : Controller
    {
        Student S2 = new Student();
        StudentDataAccessLayer objStudent = new StudentDataAccessLayer();
        // GET: Student
        public ActionResult Index()
        {

            List<Student> lstStudent = new List<Student>();
            lstStudent = objStudent.GetAllStudent();

            return View(lstStudent);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]

        public ActionResult Create(Student student)
        {

            objStudent.AddStudent(student);

            return RedirectToAction("Index");

        }


        [HttpGet]
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpNotFoundResult("Not Found");
            }
            Student student = objStudent.GetStudentData(id);


            if (student == null)
            {
                return new HttpNotFoundResult("Not Found");
            }
            return View(student);
        }



        [HttpGet]
        public ActionResult Delete(int? id)
        {

            Student student = objStudent.GetStudentData(id);

            return View(student);
        }

        [HttpPost, ActionName("Delete")]
        public ActionResult confirmDelete(int? id)
        {
            objStudent.DeleteStudent(id);

            return RedirectToAction("Index");
        }


        [HttpGet]
        public ActionResult Edit(int? id)
        {
            Student student = objStudent.GetStudentData(id);



            return View(student);
        }

        [HttpPost]// submit operation

        public ActionResult Edit(Student student)
        {

            objStudent.UpdateStudent(student);

            return RedirectToAction("Index");


        }


    }
}