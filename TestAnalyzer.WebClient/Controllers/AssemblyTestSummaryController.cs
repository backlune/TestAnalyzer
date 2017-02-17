using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using TestAnalyzer.Models;

namespace TestAnalyzer.WebClient.Controllers
{
   [Route("api/[controller]")]
   public class AssemblyTestSummaryController : Controller
   {
      public IEnumerable<AssemblyTestSummary> Get()
      {
         var tas = new TestAnalysisService();
         return tas.DoIt();
      }

   }

  
}