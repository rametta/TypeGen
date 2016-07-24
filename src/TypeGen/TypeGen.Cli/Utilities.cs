﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TypeGen.Core;

namespace TypeGen.Cli
{
    internal class Utilities
    {
        public static string GetFileNameFromPath(string path)
        {
            return path.Split('\\').Last();
        }

        public static string ChangeFileExtension(string fileName, string toExt)
        {
            string fileNameNoExt = fileName.Split('.').First();
            return $"{fileNameNoExt}.{toExt}";
        }
    }
}
