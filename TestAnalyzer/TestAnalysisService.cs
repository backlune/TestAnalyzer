using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using TestParser.Core;

namespace TestAnalyzer
{
    public class TestAnalysisService
    {

       public void AnalyzeFolder(string trxFolderName)
       {
         var files = System.IO.Directory.GetFiles(trxFolderName);
         var trxFiles = files.Where(f => f.EndsWith(".trx"));

         var resultsFactory = new TestResultFactory();
         var results = resultsFactory.CreateResultsFromTestFiles(trxFiles); // Need dependencies to TestParser.Core!
         //results.SlowestTests

         results.Summarise(); // When?

         var assemblySummaries = results.SummaryByAssembly;
         var classSummaries = results.SummaryByClass;

         // Save parts in store 
         //TODO: Make json serializable classes
         //TODO: Create a data store
      }

    }

   public class TestRunResult
   {

   }

   public class TestAssemblyResult
   {

   }

   public class TestClassResult
   {

   }

   public class TestMethodResult
   {

   }
}
