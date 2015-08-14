﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCTraining.Controllers
{
    public class CuisineController : Controller
    {
        // GET: Cuisine

        public ActionResult Index(string name)
        {
            var message = Server.HtmlEncode(name);

            return Content(message);
        }
    }
}