// MssqlDbFileExportPathInput.cs
//
// This generated file is part of the Rubrik PowerShell SDK.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Rubrik.SecurityCloud.Types
{
    #region MssqlDbFileExportPathInput

    public class MssqlDbFileExportPathInput: IInput
    {
        #region members

        //      C# -> System.String? NewFilename
        // GraphQL -> newFilename: String (scalar)
        [JsonProperty("newFilename")]
        public System.String? NewFilename { get; set; }

        //      C# -> System.String? NewLogicalName
        // GraphQL -> newLogicalName: String (scalar)
        [JsonProperty("newLogicalName")]
        public System.String? NewLogicalName { get; set; }

        //      C# -> System.String? ExportPath
        // GraphQL -> exportPath: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("exportPath")]
        public System.String? ExportPath { get; set; }

        //      C# -> System.String? LogicalName
        // GraphQL -> logicalName: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("logicalName")]
        public System.String? LogicalName { get; set; }


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

    } // class MssqlDbFileExportPathInput
    #endregion

} // namespace Rubrik.SecurityCloud.Types