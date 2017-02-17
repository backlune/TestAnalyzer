using System.Collections.Generic;

namespace TestAnalyzer.Models
{
   public class AssemblyTestDetailedSummary
   {
      public string AssemblyName { get; set; }
      public IEnumerable<ClassTestSummary> ClassSummaries { get; set; }
   }
}