using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using Newtonsoft.Json.Linq;

namespace RubrikSecurityCloud.PowerShell.Private
{
    internal class RscCmdletHelper
    {
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

