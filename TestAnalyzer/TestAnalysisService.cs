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

       public void DoIt()
       {
         var resultsFactory = new TestResultFactory();
          var results = resultsFactory.CreateResultsFromTestFiles(new List<string>());
         var outputCreator = new ParsedDataOutputter();
         //outputCreator.OutputResults(results);

         // run parse over all trx files

         // Parse JSON

         // Split json

         // Save parts in store
      }

    }
}
