﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHomeFinal.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Moderator, Admin")]
    public class Dashboard : Controller
    {
       

        public IActionResult Index()
        {
            return View();
        }
    }
}
