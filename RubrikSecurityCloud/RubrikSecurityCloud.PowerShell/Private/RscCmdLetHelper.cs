using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using Newtonsoft.Json.Linq;

namespace Rubrik.SecurityCloud.PowerShell.Private
{
    internal class RscCmdletHelper
    {
        public static Dictionary<string, string> GetCmdletValidGraphQLOperations(string cmdletName)
        {
            var assembly = Assembly.GetExecutingAssembly();
            string resouceName = assembly.GetManifestResourceNames().
                Where(n => n.Contains("cmdletGraphQLOperationsManifest.json")).
                FirstOrDefault();

            var results = assembly.GetManifestResourceNames();
            Stream stream = assembly.GetManifestResourceStream(resouceName);
            StreamReader reader = new StreamReader(stream);
            string readerAsString = reader.ReadToEnd();

            JToken readerObject = JToken.Parse(readerAsString);

            Dictionary<string, string> returnData = new Dictionary<string, string>();

            if (readerObject[cmdletName] != null)
            {
                foreach (JProperty jToken in readerObject[cmdletName])
                {
                    returnData.Add(jToken.Name, jToken.Value.ToString());
                }
            }
            return returnData;
        }

        public static bool CheckAllPropertiesAreNull(object obj)
        {
            if (obj != null)
            {
                var type = obj.GetType();
                var properties = type.GetProperties(BindingFlags.Public | BindingFlags.Instance);

                foreach (var property in properties)
                {
                    if (property.GetValue(obj) != null)
                    {
                        return false;
                    }
                }

                return true;
            }
            else
            {
                return true;
            }
        }
    }
}

