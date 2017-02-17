using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using TestAnalyzer.Models;
using TestParser.Core;

namespace TestAnalyzer
{
    public class TestAnalysisService
    {

       public IEnumerable<AssemblyTestSummary> DoIt()
       {
          var testfiles =  Directory.GetFiles(@"F:\Development\TestAnalyzer\TestResultsExample", "*.trx");

         var resultsFactory = new TestResultFactory();
         var results = resultsFactory.CreateResultsFromTestFiles(testfiles);
         
         
         return results.SummaryByAssembly.SummaryLines.Select(s => new AssemblyTestSummary()
         {
            AssemblyName = s.AssemblyFileName,
            Passed = s.TotalPassed,
            Failed = s.TotalTests - s.TotalPassed,
            DurationInSeconds = s.TotalDurationInSecondsHuman,
            PercentagePassed = s.PercentPassed
         });

         // run parse over all trx files

         // Parse JSON

         // Split json

         // Save parts in store
      }

       public AssemblyTestDetailedSummary GetDetailSummary(string assemblyFileName)
       {
         var testfiles = Directory.GetFiles(@"F:\Development\TestAnalyzer\TestResultsExample", "*.trx");

         var resultsFactory = new TestResultFactory();
         var results = resultsFactory.CreateResultsFromTestFiles(testfiles);

          var assenblyTestInfo = results.SummaryByAssembly.SummaryLines.FirstOrDefault(s => s.AssemblyFileName == assemblyFileName);

          var classInAssemblyTestSummary =
             results.SummaryByClass.SummaryLines.Where(s => s.AssemblyFileName == assemblyFileName).Select(x => new ClassTestSummary()
             {
                ClassName =  x.ClassName,
                Passed = x.TotalPassed,
                Failed = x.TotalTests - x.TotalPassed,
                DurationInSeconds = x.TotalDurationInSecondsHuman,
                PercentagePassed = x.PercentPassed
             } );

         return new AssemblyTestDetailedSummary()
         {
            AssemblyName = assenblyTestInfo.AssemblyFileName,
            ClassSummaries = classInAssemblyTestSummary
         };

       }

       public TestSummary GetTestSummary()
       {
         var testfiles = Directory.GetFiles(@"F:\Development\TestAnalyzer\TestResultsExample", "*.trx");

         var resultsFactory = new TestResultFactory();
         var results = resultsFactory.CreateResultsFromTestFiles(testfiles);


         return new TestSummary()
         {
            TotalPassed = results.SummaryByAssembly.TotalPassed,
            TotalTests = results.SummaryByAssembly.TotalTests,
            PercentagePassed = results.SummaryByAssembly.PercentPassed,
           TotalDuration = results.SummaryByAssembly.TotalDurationInSecondsHuman,
           SlowestTest = results.SlowestTests.Select(x => new TestWithTime()
           {
              Name = x.TestName,
              Duration = x.DurationHuman
           })
         };
      }
    }

  
}
