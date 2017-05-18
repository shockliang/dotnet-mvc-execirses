using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCLab.Controllers
{
    public class HelloWorldController : Controller
    {
        // 
        // GET: /HelloWorld/ 

        public ActionResult Index()
        {
            return View();
        }

        // 
        // GET: /HelloWorld/Welcome/ 

        public ActionResult Welcome(string name, int numTimes = 1)
        {
            ViewBag.Message = "Hello" + name;
            ViewBag.NumTimes = numTimes;
            return View();
        }

        //public string Welcome(string name, int id = 1)
        //{
        //    return HttpUtility.HtmlEncode(string.Format("Hello {0}, ID: {1}", name, id));
        //}

        //public string Welcome(Personal personal)
        //{
        //    try
        //    {
        //        if (ModelState.IsValid)
        //        {
        //            // Submit the changes to the database here

        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        // Log the exception somewhere to be looked at later
        //        ModelState.AddModelError("*", "An unexpected error occurred.");
        //    }
        //    return HttpUtility.HtmlEncode(string.Format("Helllo {0}, num times is :{1}", personal.Name, personal.NumTimes));
        //}

        /// <summary>
        /// This result was very trick when pass the paramaters like /HelloWorld/Test/1&id=2. The var id will be 1 but not 2.
        /// Cause the model binding of asp.net mvc that using ValueProviderFactory to parse the paramaters. It has 6 differences value
        /// data provider to parse paramaters.
        /// Ref:http://blog.miniasp.com/post/2015/11/08/ASPNET-MVC-Developer-Note-Part-25-Value-Provider-and-Model-Binder.aspx
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public string Test(int id)
        {
            //var resutl = HttpContext.Current.Request[id.ToString()];
            //var result = HttpContext.Request[id.ToString()];
            var result = System.Web.HttpContext.Current.Request[id.ToString()];

            return HttpUtility.HtmlEncode(string.Format("Test id:{0}", id));
        }
    }

    public class Personal
    {
        [Required(AllowEmptyStrings =false, ErrorMessage ="Required name")]
        public string Name { get; set; }

        [Required]
        public int NumTimes { get; set; }

    }
}