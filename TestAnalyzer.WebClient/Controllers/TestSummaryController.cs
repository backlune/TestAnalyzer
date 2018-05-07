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
      private readonly ITestAnalysisService m_testAnalysisService;

      public TestSummaryController(ITestAnalysisService testAnalysisService)
      {
         m_testAnalysisService = testAnalysisService;
      }

      [HttpGet]
      public TestSummary Get()
      {
         return m_testAnalysisService.GetTestSummary();
      }

    }
}
