// FilesetOptionsInput.cs
//
// This generated file is part of the Rubrik PowerShell SDK.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using RubrikSecurityCloud.Schema.Utils;

namespace Rubrik.SecurityCloud.Types
{
    #region FilesetOptionsInput

    public class FilesetOptionsInput: IInput
    {
        #region members

        //      C# -> System.Boolean? AllowBackupHiddenFoldersInNetworkMounts
        // GraphQL -> allowBackupHiddenFoldersInNetworkMounts: Boolean (scalar)
        [JsonProperty("allowBackupHiddenFoldersInNetworkMounts")]
        public System.Boolean? AllowBackupHiddenFoldersInNetworkMounts { get; set; }

        //      C# -> System.Boolean? AllowBackupNetworkMounts
        // GraphQL -> allowBackupNetworkMounts: Boolean (scalar)
        [JsonProperty("allowBackupNetworkMounts")]
        public System.Boolean? AllowBackupNetworkMounts { get; set; }

        //      C# -> System.Boolean? UseWindowsVss
        // GraphQL -> useWindowsVss: Boolean (scalar)
        [JsonProperty("useWindowsVss")]
        public System.Boolean? UseWindowsVss { get; set; }


        #endregion

    
        #region methods
        public dynamic GetInputObject()
        {
            IDictionary<string, object> d = new System.Dynamic.ExpandoObject();

            var properties = GetType().GetProperties(System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Public);
            foreach (var propertyInfo in properties)
            {
                var value = propertyInfo.GetValue(this);
                var defaultValue = propertyInfo.PropertyType.IsValueType ? Activator.CreateInstance(propertyInfo.PropertyType) : null;

                var requiredProp = propertyInfo.GetCustomAttributes(typeof(JsonRequiredAttribute), false).Length > 0;

                if (requiredProp || value != defaultValue)
                {
                    d[propertyInfo.Name] = value;
                }
            }
            return d;
        }
        #endregion

    } // class FilesetOptionsInput
    #endregion

} // namespace Rubrik.SecurityCloud.Types