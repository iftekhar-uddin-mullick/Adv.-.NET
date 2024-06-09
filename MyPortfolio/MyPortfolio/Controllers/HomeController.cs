using MyPortfolio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyPortfolio.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            PersonEntity person = new PersonEntity()
            {
                PersonName = "Iftekhar Uddin Mullick",
                PersonEmail = "iftekhar.uddin.mullick@gmail.com",
                PersonPhoneNumber = "01511098765",
                PersonDegree = "Bachelors",
                PersonExpertise = "C#, C++, JavaScript, NodeJS"
            };

            ViewBag.Person = new PersonEntity[] {person};

            return View();
        }

        public ActionResult Education()
        {
            EducationEntity e1 = new EducationEntity()
            {
                EducationName = "HSC",
                EducationYear = 2020,
                EducationGroup = "Science",
                EducationInstitute = "Dhaka Residential Model College (DRMC)"
            };
            EducationEntity e2 = new EducationEntity()
            {
                EducationName = "SSC",
                EducationYear = 2018,
                EducationGroup = "Science",
                EducationInstitute = "Dhaka Residential Model College (DRMC)"
            };

            ViewBag.Education = new EducationEntity[] {e1, e2};

            return View();
        }

        public ActionResult Projects()
        {
            ProjectsEntity p1 = new ProjectsEntity()
            {
                ProjectTitle = "Banking Management System",
                ProjectDesc = "A simple command line banking management system",
                ProjectCourse = "OOP1 (Java)"
            };
            ProjectsEntity p2 = new ProjectsEntity()
            {
                ProjectTitle = "Parcel Management System",
                ProjectDesc = "A GUI-based parcel management system",
                ProjectCourse = "OOP2 (C#)"
            };
            ProjectsEntity p3 = new ProjectsEntity()
            {
                ProjectTitle = "Hospital Management System",
                ProjectDesc = "A HTML, CSS, PHP based Web Project for Hospital Management system",
                ProjectCourse = "Webtech"
            };
            ProjectsEntity p4 = new ProjectsEntity()
            {
                ProjectTitle = "SaaS-based Hospital Management System",
                ProjectDesc = "A SaaS Oriented Hospital Management system with Multi-tenency and AI integration",
                ProjectCourse = "Adv. Webtech"
            };

            ViewBag.Projects = new ProjectsEntity[] {p1, p2, p3, p4};

            return View();
        }

        public ActionResult Certifications()
        {


            return View();
        }
        public ActionResult References()
        {
            ViewBag.Reference1 = "MD. AL-AMIN";
            ViewBag.Reference2 = "S M ABDULLAH SHAFI";

            return View();
        }
        public ActionResult ReferenceDetails(string refName)
        {
            ViewBag.RefName = refName;

            return View();
        }



    }
}