﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace NetCoreWebSiHang
{
    [Route("home")]
    public class HomeController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        [Route("hello")]
        public string hello()
        {
            return "hello sihang";
        }

        [Route("hello/lulu")]
        public string helloLulu()
        {
            return "lulu is daxiongmei";
        }
    }
}
