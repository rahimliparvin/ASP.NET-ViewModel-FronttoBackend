using Layout_ViewModels.Models;
using Layout_ViewModels.ViewModels.Home;
using Microsoft.AspNetCore.Mvc;

namespace Layout_ViewModels.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {

            Student stu1 = new()
            {

                Id = 1,
                FullName = "Parvin Rahimli",
                Age = 26

            };

            Student stu2 = new()
            {

                Id = 2,
                FullName = "Ali Talibov",
                Age = 21

            };

            Student stu3 = new()
            {

                Id = 3,
                FullName = "Mirze Beshirzade",
                Age = 27

            };

            List<Student> students = new() { stu1, stu2, stu3 };

            //Product product = new()
            //{
            //    Id = 1,
            //    Name = "Samsung 11",
            //};

            Product product = new()
            {
                Id = 1,
                Name = "Samsung 11",
                Price = 200,
                Description = "Description",
                Count = 10
            };

            ProductVM productVM = new()
            {
                Name = product.Name,
                Price = product.Price
            };


            HomeVM model = new()
            {
                Students = students,
                Product = productVM
            };



            return View(model);




            #region Model to View


            // ViewData["names"] = new string[] { "Elcan", "Parvin", "Aqshin" };

            // ViewBag.numbers = new int[] { 10, 20, 30, 40 };

            // List<int> nums = new List<int>() { 1,2,3,4,5};

            //TempData["surname"] = "Qurbanov";

            //return RedirectToAction(nameof(Detail));

            //string name = "Xaker";

            //return View((object)name);


            //Student stu1 = new()
            //{

            //    Id = 1,
            //    FullName = "Parvin Rahimli",
            //    Age = 26

            //};

            //Student stu2 = new()
            //{

            //    Id = 2,
            //    FullName = "Ali Talibov",
            //    Age = 21

            //};

            //Student stu3 = new()
            //{

            //    Id = 3,
            //    FullName = "Mirze Beshirzade",
            //    Age = 27

            //};

            //List<Student> students = new() { stu1, stu2, stu3 };


            //return View(students);

            // return View(stu1);

            //  ViewBag.address = "Sumqayit";

            #endregion

        }

        //public IActionResult Detail()
        //{
        //    return View();


        //}
    }
}
