using System;
using System.Collections.Generic;
using System.Text;

namespace NUnitTest
{
    public class LogAnalyzer
    {
        private readonly IExtensionManager manager;
        public LogAnalyzer(IExtensionManager mng)
        {
            manager = mng;
        }


        public bool ResultCalledIsValidLogFileNameMethod { get; set; }


        public bool IsValidLogFileName(string fileName)
        {
            
            return manager.IsValid(fileName);

            
        }
    }
    
}
