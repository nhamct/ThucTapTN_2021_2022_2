using DUE_Complains.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Configuration;
using Microsoft.Extensions.Configuration;
using DUE_Complains.Dtos;
using DUE_Complains.Dtos.Complains;
using Microsoft.AspNetCore.Authorization;

namespace DUE_Complains.Controllers
{

    public class HomeController : Controller
    {

        private readonly IComplainsManagement _complainsManagement;


        public HomeController(IComplainsManagement complainsManagement)
        {
            _complainsManagement = complainsManagement;
        }

        [AllowAnonymous]
        public async Task<IActionResult> Index()
        {
            var complains = await _complainsManagement.GetAll();
            return View(complains);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
