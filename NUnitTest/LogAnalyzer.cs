using System;
using System.Collections.Generic;
using System.Text;

namespace NUnitTest
{
    public class LogAnalyzer
    {
        public bool ResultCalledIsValidLogFileNameMethod { get; set; }
        public bool IsValidLogFileName(string fileName)
        {
            ResultCalledIsValidLogFileNameMethod = false;
            if(fileName == string.Empty)
            {
                throw new ArgumentNullException("You shuld write file name");
            }
            if (fileName.EndsWith(".SLF", StringComparison.CurrentCultureIgnoreCase))
            {
                ResultCalledIsValidLogFileNameMethod = true;
                return true;
            }
            return false;
        }
    }
}
