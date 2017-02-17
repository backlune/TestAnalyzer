namespace TestAnalyzer.Models
{
   public class ClassTestSummary
   {
      public string ClassName { get; set; }

      public int Passed { get; set; }

      public int Failed { get; set; }
      public string DurationInSeconds { get; set; }
      public double PercentagePassed { get; set; }
   }
}