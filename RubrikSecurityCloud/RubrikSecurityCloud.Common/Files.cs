using System;
using System.IO;
using System.Collections;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Reflection;

namespace RubrikSecurityCloud
{
    public static class Files
    {
        public static string DefaultServiceAccountFileName = "rsc_service_account_default.xml";

        public static string GetAssemblyDir()
        {
            string assemblyPath = System.Reflection.Assembly.GetExecutingAssembly().Location;
            return System.IO.Path.GetDirectoryName(assemblyPath);
        }

        public static string GetSdkOperationsDir(string InputProfileName)
        {
            string assemblyDir = GetAssemblyDir();
            return Path.Combine(assemblyDir, "..", "Operations", InputProfileName);
        }

        // return empty string if file doesn't exist
        public static string ReadFileIfExists(string filePath)
        {
            if (!File.Exists(filePath))
            {
                return "";
            }
            return File.ReadAllText(filePath);
        }

        public static void WriteFile(
            string filePath, 
            string fileContents,
            bool backupIfExists = true)
        {
            if (backupIfExists && System.IO.File.Exists(filePath))
            {
                string backupFilePath = filePath + ".bak";
                // this will overwrite any existing backup file
                System.IO.File.Copy(filePath, backupFilePath, true);
            }
            System.IO.File.WriteAllText(filePath, fileContents);
        }
    }
}
