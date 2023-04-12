using NUnit.Framework;
using System;

namespace NUnitTest.UnitTests
{
    [TestFixture]
    public class LogAnalyzerTests
    {
        private static LogAnalyzer CreateLogAnalyzer()
        {
            return new LogAnalyzer();
        }

        [TestCase("file1.SLF")]
        [TestCase("file1.slf")]
        public void IsValidFileName_BadExtension_ReturnTrue(string file)
        {
            // Arrange - подготовка объектов, то есть создание и настройка
            LogAnalyzer analyzer = CreateLogAnalyzer();

            // Act - воздействие на объект
            bool result = analyzer.IsValidLogFileName(file);

            // Assert - утверждение об ожидаемом результате

            Assert.True(result);

        }

        [Test]
        public void IsValidFileName_ThrowException_ReturnTrue()
        {
            LogAnalyzer analyzer =  CreateLogAnalyzer();

            var exception = Assert.Catch<Exception>(() => analyzer.IsValidLogFileName(""));
            
            StringAssert.Contains("You shuld write file name", exception.Message);
        }
        [Test]
        [TestCase("file1.foo", false) ]
        [TestCase("file1.slf", true)]
        public void ResultCalledIsValidLogFileNameMethod_WhenValid_ReturnTrue(string file, bool expected)
        {
            LogAnalyzer analyzer = CreateLogAnalyzer();

            analyzer.IsValidLogFileName(file);

            Assert.AreEqual(expected, analyzer.ResultCalledIsValidLogFileNameMethod);
        }


        
    }
}