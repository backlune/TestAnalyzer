using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAnalyzer.Models
{
   public class AssemblyTestSummary
   {
      public string AssemblyName { get; set; }

      public int Passed { get; set; }

      public int Failed { get; set; }

      public string DurationInSeconds { get; set; }

      public double PercentagePassed { get; set; }
   }
}
