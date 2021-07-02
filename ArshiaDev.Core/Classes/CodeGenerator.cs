using System;
using System.Collections.Generic;
using System.Text;

namespace ArshiaDev.Core.Classes
{
    public static class CodeGenerator
    {
        public static string FileCode()
        {
            return Guid.NewGuid().ToString();
        }
    }
}
