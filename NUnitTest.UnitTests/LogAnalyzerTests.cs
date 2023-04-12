using NUnit.Framework;
using System;

namespace NUnitTest.UnitTests
{
    [TestFixture]
    public class LogAnalyzerTests
    {
        [TestCase("file1.SLF")]
        [TestCase("file1.slf")]
        public void IsValidFileName_BadExtension_ReturnTrue(string file)
        {
            // Arrange - подготовка объектов, то есть создание и настройка
            LogAnalyzer analyzer = new LogAnalyzer();

            // Act - воздействие на объект
            bool result = analyzer.IsValidLogFileName(file);

            // Assert - утверждение об ожидаемом результате

            Assert.True(result);

        }
        
    }
}