﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace student_testing.Controllers
{
    public class SettingsController : Controller
    {
        public IActionResult Account()
        {
            return View();
        }
    }
}
