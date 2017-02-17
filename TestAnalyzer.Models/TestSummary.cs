using System.Collections.Generic;

namespace TestAnalyzer.Models
{
   public class TestSummary
   {
      public double PercentagePassed { get; set; }
      public string TotalDuration { get; set; }
      public int TotalPassed { get; set; }
      public int TotalTests { get; set; }
      public IEnumerable<TestWithTime> SlowestTest { get; set; }
   }


   public class TestWithTime
   {
      public string Duration { get; set; }
      public string Name { get; set; }
   }

}