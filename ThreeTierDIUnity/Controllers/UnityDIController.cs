using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ThreeTierDIUnity.Services;

namespace ThreeTierDIUnity.Controllers
{
    public class UnityDIController : Controller
    {
        // GET: UnityDI
        private IEmployee _emp;
        UnityDIController(IEmployee e)
        {
            _emp = e;
        }
        public ActionResult Create()
        {
            return View();
        }
        public ActionResult Index()
        {

            return View();
        }
    }
}