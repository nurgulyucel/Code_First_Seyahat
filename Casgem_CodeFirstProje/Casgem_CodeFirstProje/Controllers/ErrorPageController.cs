﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Casgem_CodeFirstProje.Controllers
{
    public class ErrorPageController : Controller
    {
        
        public ActionResult Page404()
        {
            return View();
        }
    }
}