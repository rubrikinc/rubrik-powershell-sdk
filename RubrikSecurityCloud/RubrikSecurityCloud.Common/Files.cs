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
        /// <summary>
        /// Get the RSC SDK's user profile directory.
        /// Typically "$(Split-Path $PROFILE -Parent)/rubrik-powershell-sdk"
        /// But resolves to the current directory if $PROFILE is not defined.
        /// </summary>
        public static string GetUserProfileDir(string sessionOverride="")
        {
            string profPath = sessionOverride;
            if (string.IsNullOrEmpty(profPath))
            {
                profPath = Environment.GetEnvironmentVariable("PROFILE");
            }
            // if not defined, use default
            if (string.IsNullOrEmpty(profPath))
            {
                profPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile));
            }
            // if not defined, use cwd
            if (string.IsNullOrEmpty(profPath))
            {
                return Directory.GetCurrentDirectory();
            }
            // if it's a file, get its directory
            if ( File.Exists(profPath) )
            {
                profPath = Path.GetDirectoryName(profPath);
            } else if (!Directory.Exists(profPath)) {
                // see if parent directory exists
                profPath = Path.GetDirectoryName(profPath);
                if (!Directory.Exists(profPath)) {
                        throw new DirectoryNotFoundException("Could not find: " + profPath);
                }
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

        /// <summary>
        /// Get the RSC SDK user's custom directory from
        /// the RSC_CUSTOM_DIR environment variable. If not defined,
        /// return the current directory.
        /// </summary>
        public static string GetCustomDir(string sessionOverride="")
        {
            string customDir = sessionOverride;
            if ( string.IsNullOrEmpty(customDir) ) {
                customDir = Environment.GetEnvironmentVariable("RSC_CUSTOM_DIR");
            }
            // If RSC_CUSTOM_DIR is defined, and valid, use it
            // otherwise use cwd
            if (string.IsNullOrEmpty(customDir) || !Directory.Exists(customDir)) {
                return Directory.GetCurrentDirectory();
            }
            return customDir;
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
