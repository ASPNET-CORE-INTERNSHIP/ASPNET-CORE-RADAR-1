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
    public class AddTransmitterController : Controller
    {
        //We need configuration for calling db.
        private IConfiguration _configuration;
        public AddTransmitterController(IConfiguration Configuration) { _configuration = Configuration; }

        [Route("Home/Index")]
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult NewTransmitter()
        {
            return View();
        }

        //id represents the receiver id so when it comes to create a radar we will use this value.
        [HttpPost]
        public IActionResult NewTrasmitter(AddTransmitter transmitter, Guid? id)
        {
            using (SqlConnection con = new SqlConnection(@"Server=localhost;Database=RADAR;Trusted_Connection=True;MultipleActiveResultSets=true"))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = @"INSERT INTO Transmitter(ID, name, modulation_type, max_frequency, min_frequency, power) 
                            VALUES(@ID, @name, @modulation_type, @max_frequency, @min_frequency, @power)";
                    Guid key = Guid.NewGuid();
                    cmd.Parameters.AddWithValue("@ID", key);
                    cmd.Parameters.AddWithValue("@name", transmitter.name);
                    cmd.Parameters.AddWithValue("@modulation_type", transmitter.modulation_type);
                    cmd.Parameters.AddWithValue("@max_frequency", transmitter.max_frequency);
                    cmd.Parameters.AddWithValue("@min_frequency", transmitter.min_frequency);
                    cmd.Parameters.AddWithValue("@power", transmitter.power);
                    try
                    {
                        con.Open();
                        int i = cmd.ExecuteNonQuery();
                        if (i != 0)
                            ViewData["Message"] = "New Transmitter added";
                        con.Close();
                        return RedirectToAction("NewAntenna", "AddAntenna", new { @id = key });
                    }
                    catch (SqlException e)
                    {
                        ViewData["Message"] = e.Message.ToString() + " Error";
                    }

                }
            }
            return View(transmitter);
        }
    }
}
