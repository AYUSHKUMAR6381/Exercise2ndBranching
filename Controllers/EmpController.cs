using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebAppExercise2nd_GitHub_Branches_03_12.Models;

namespace WebAppExercise2nd_GitHub_Branches_03_12.Controllers
{
    public class EmpController : Controller
    {
        List<Emp> eList = new List<Emp>()
        {
            new Emp{EId=1,EName="Ayush",EDesig="HR",ESalary=1000 },
            new Emp{EId=2,EName="Salmaan",EDesig="Manager",ESalary=2000 },
            new Emp{EId=3,EName="Rajiv",EDesig="Devloper",ESalary=3000 },
            new Emp{EId=4,EName="Arpan",EDesig="CEO",ESalary=4000 },
            new Emp{EId=5,EName="Jayant",EDesig="COO",ESalary=5000 }
        };
        public IActionResult Index()
        { 
            return View(eList);
        }
    }
}
