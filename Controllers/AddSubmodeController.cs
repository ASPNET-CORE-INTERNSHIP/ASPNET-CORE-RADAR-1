﻿using ASPNETAOP.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNETAOP.Controllers
{
    public class AddSubmodeController : Controller
    {
        //We need configuration for calling db.
        private IConfiguration _configuration;
        public AddSubmodeController(IConfiguration Configuration) { _configuration = Configuration; }

        [Route("Home/Index")]
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult NewSubmode()
        {
            return View();
        }


        [HttpPost]
        public IActionResult NewSubmode(AddSubmode sm)
        {
            TempData["name"] = sm.name;

            TempData["PW"] = sm.PW;

            TempData["PRI"] = sm.PRI;

            TempData["min_frequency"] = sm.min_frequency;

            TempData["max_frequency"] = sm.max_frequency;

            return RedirectToAction("NewScan", "AddScan");
            //bu kısımda hata veriyor sebebini anlamadım
        }

    }
    /*SELECT* FROM Transmitter;
SELECT* FROM Receiver;
SELECT* FROM Antenna;
SELECT* FROM Radar;
SELECT* FROM Location;
SELECT* FROM Mode;
SELECT* FROM Submode;
DELETE FROM Antenna WHERE number_of_feed < 60;
DELETE FROM Receiver WHERE rest_time < 60;
DELETE FROM Transmitter WHERE max_frequency < 60;
DELETE FROM Location WHERE city = 'GANA';
DELETE FROM Radar WHERE name = 'Friendly ';
DELETE FROM Mode WHERE name ='Friendly ';
DELETE FROM Submode WHERE PW<60;
*/
        }