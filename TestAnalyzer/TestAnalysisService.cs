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
   public class TestAnalysisService : ITestAnalysisService
   {
      private readonly string m_testLogFolder;

      public TestAnalysisService(string testLogFolder)
      {
         m_testLogFolder = testLogFolder;
      }

      //private const string TestResultFolder = @"D:\Temp\TestResults20170301";
      //private const string TestResultFolder = @"..\TestResultsExample";

      public IEnumerable<AssemblyTestSummary> GetAssemblySummary()
      {
         var testfiles = Directory.GetFiles(m_testLogFolder, "*.trx");

         var resultsFactory = new TestResultFactory();
         var results = resultsFactory.CreateResultsFromTestFiles(testfiles);


         return results.SummaryByAssembly.SummaryLines.Select(s => new AssemblyTestSummary()
         {
            AssemblyName = s.AssemblyFileName,
            Passed = s.TotalPassed,
            Failed = s.TotalTests - s.TotalPassed,
            DurationInSeconds = s.TotalDurationInSecondsHuman,
            PercentagePassed = s.PercentPassed
         }).OrderByDescending(x => x.Failed);
      }

      public AssemblyTestDetailedSummary GetDetailSummary(string assemblyFileName)
      {
         var testfiles = Directory.GetFiles(m_testLogFolder, "*.trx");

         var resultsFactory = new TestResultFactory();
         var results = resultsFactory.CreateResultsFromTestFiles(testfiles);

         var assenblyTestInfo = results.SummaryByAssembly.SummaryLines.FirstOrDefault(s => s.AssemblyFileName == assemblyFileName);

         var classInAssemblyTestSummary =
            results.SummaryByClass.SummaryLines.Where(s => s.AssemblyFileName == assemblyFileName).Select(x => new ClassTestSummary()
            {
               ClassName = x.ClassName,
               Passed = x.TotalPassed,
               Failed = x.TotalTests - x.TotalPassed,
               DurationInSeconds = x.TotalDurationInSecondsHuman,
               PercentagePassed = x.PercentPassed
            });

         return new AssemblyTestDetailedSummary()
         {
            AssemblyName = assenblyTestInfo.AssemblyFileName,
            ClassSummaries = classInAssemblyTestSummary
         };

      }

      public TestSummary GetTestSummary()
      {
         var testfiles = Directory.GetFiles(m_testLogFolder, "*.trx");

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
