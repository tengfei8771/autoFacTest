﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Services;
using Services.IServices;

namespace test1.Controllers
{
    [Route("test")]
    public class testController : Controller
    {
        private IDoServices _services;

        public testController(IDoServices services)
        {
            _services = services;
        }
        [HttpGet("Index")]
        public IActionResult Index()
        {
            return Ok(_services.dosomething());
        }
    }
}