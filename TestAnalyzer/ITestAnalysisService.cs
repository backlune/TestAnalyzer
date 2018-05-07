using System.Collections.Generic;
using TestAnalyzer.Models;

namespace TestAnalyzer
{
   public interface ITestAnalysisService
   {
      IEnumerable<AssemblyTestSummary> GetAssemblySummary();
      AssemblyTestDetailedSummary GetDetailSummary(string assemblyFileName);
      TestSummary GetTestSummary();
   }
}