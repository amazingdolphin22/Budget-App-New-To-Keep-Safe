using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetApp.Models
{
    public static class TextReaderWriter
    {
        public static char SeparatorValue { get; } = '|';
        public static string DirectorySeparator { get; } = "\\";
        public static string DBaseLocation { get; } = GetDbaseLocation(); //Directory.GetCurrentDirectory() + DirectorySeparator + "Dbase";

        private static string GetDbaseLocation()
        {
            //Get Current Directory
            string dir = Directory.GetCurrentDirectory();
            //Remove all paths after name of project
            dir = dir.Substring(0, dir.IndexOf("bin"));
            //Navigate to DBase folder
            dir += "DBase" + DirectorySeparator;
            return dir;
        }
    }
}
