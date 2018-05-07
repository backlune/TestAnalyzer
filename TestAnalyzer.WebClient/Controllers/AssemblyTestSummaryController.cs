using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using TestAnalyzer.Models;

namespace TestAnalyzer.WebClient.Controllers
{
   [Route("api/[controller]")]
   public class AssemblyTestSummaryController : Controller
   {
      private readonly ITestAnalysisService m_testAnalysisService;

      public AssemblyTestSummaryController(ITestAnalysisService testAnalysisService)
      {
         m_testAnalysisService = testAnalysisService;
      }

      public IEnumerable<AssemblyTestSummary> Get()
      {
         return m_testAnalysisService.GetAssemblySummary();
      }

   }

  
}