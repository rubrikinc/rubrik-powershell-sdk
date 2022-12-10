// AllCloudDirectSharesInput.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:04:11.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Rubrik.SecurityCloud.Types
{
    #region AllCloudDirectSharesInput

    public class AllCloudDirectSharesInput
    {
        #region members
        //      C# -> System.String? SystemName
        // GraphQL -> systemName: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("systemName")]
        public System.String? SystemName { get; set; }

        //      C# -> ShareTypeEnum? ExportType
        // GraphQL -> exportType: ShareTypeEnum! (enum)
        [Required]
        [JsonRequired]
        [JsonProperty("exportType")]
        public ShareTypeEnum? ExportType { get; set; }

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

    } // class AllCloudDirectSharesInput
    #endregion

} // namespace Rubrik.SecurityCloud.Types