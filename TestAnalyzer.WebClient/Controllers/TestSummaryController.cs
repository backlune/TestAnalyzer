using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TestAnalyzer.Models;

namespace TestAnalyzer.WebClient.Controllers
{
   [Route("api/[controller]")]
   public class TestSummaryController : Controller
   {
      [HttpGet]
      public TestSummary Get()
      {
         var tas = new TestAnalysisService();
         return tas.GetTestSummary();
      }

    }
}
