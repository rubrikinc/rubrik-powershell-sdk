using System;
using System.IO;
using System.Collections;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Reflection;

namespace RubrikSecurityCloud
{
    public static class FileUtils
    {
        public static string GetUserProfileDir(string profPath="")
        {
            if (string.IsNullOrEmpty(profPath))
            {
                profPath = Environment.GetEnvironmentVariable("PROFILE");
            }
            // if it's a file, get its directory
            if ( File.Exists(profPath) )
            {
                profPath = Path.GetDirectoryName(profPath);
            }
            if (!Directory.Exists(profPath))
            {
                throw new DirectoryNotFoundException("Could not find: " + profPath);
            }
            profPath= Path.Combine(profPath, "rubrik-powershell-sdk");
            // if it doesn't exist, create it
            if (!Directory.Exists(profPath))
            {
                Directory.CreateDirectory(profPath);
            }
            return profPath;
        }

        public static string GetAssemblyDir()
        {
            string assemblyPath = System.Reflection.Assembly.GetExecutingAssembly().Location;
            return System.IO.Path.GetDirectoryName(assemblyPath);
        }

        public static string GetUserOperationsDir(string profPath="")
        {
            profPath = GetUserProfileDir(profPath);
            profPath = Path.Combine(profPath, "Operations");
            // if it doesn't exist, create it
            if (!Directory.Exists(profPath))
            {
                Directory.CreateDirectory(profPath);
            }
            return profPath;
        }

        public static string GetSdkOperationsDir(string InputProfileName)
        {
            string assemblyDir = GetAssemblyDir();
            return Path.Combine(assemblyDir, "Operations", InputProfileName);
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
    }
}
