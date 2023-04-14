using NUnit.Framework;
using System;
using NUnitTest;

namespace NUnitTest.UnitTests
{
    [TestFixture]
    public class LogAnalyzerTests
    {


        [TestCase("file1.SLF")]
        [TestCase("file1.slf")]
        public void IsValidFileName_SupportedExtension_ReturnTrue(string file)
        {
            FakeExtensionManager fakeManager = new FakeExtensionManager();

            fakeManager.WillBeValid = true;

            LogAnalyzer analyzer = new LogAnalyzer(fakeManager);

            bool result = analyzer.IsValidLogFileName(file);


            Assert.True(result);
        }


        
    }
}