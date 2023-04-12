using System;
using System.Collections.Generic;
using System.Text;

namespace NUnitTest
{
    public class LogAnalyzer
    {
        public bool IsValidLogFileName(string fileName)
        {
            if (fileName.EndsWith(".SLF", StringComparison.CurrentCultureIgnoreCase))
            {
                return true;
            }
            return false;
        }
    }
}
