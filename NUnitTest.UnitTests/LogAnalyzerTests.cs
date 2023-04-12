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
            // Arrange - ���������� ��������, �� ���� �������� � ���������
            LogAnalyzer analyzer = new LogAnalyzer();

            // Act - ����������� �� ������
            bool result = analyzer.IsValidLogFileName(file);

            // Assert - ����������� �� ��������� ����������

            Assert.True(result);

        }
        
    }
}