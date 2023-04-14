using System;
using System.Collections.Generic;
using System.Text;

namespace NUnitTest
{
    public class FileExtensionManager:IExtensionManager
    {
        public bool IsValid(string fileName)
        {
            return false;
        }
    }

    public class FakeExtensionManager : IExtensionManager
    {
        public bool WillBeValid = false;
        public bool IsValid(string fileName)
        {
            return WillBeValid;
        }
    }
}
