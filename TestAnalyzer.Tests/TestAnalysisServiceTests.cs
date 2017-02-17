using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAnalyzer.Tests
{
   [TestClass]
    public class TestAnalysisServiceTests
    {

      [TestMethod]
      public void AnalyzeFolder_TryIt()
      {
         var ta = new TestAnalysisService();

         ta.AnalyzeFolder(@"C:\Users\emil\Documents\GitHub\TestAnalyzer\TestAnalyzer.Tests\TestData");

      }
    }
}
