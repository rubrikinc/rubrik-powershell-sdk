// SapHanaSystemCopyConfigInput.cs
//
// This generated file is part of the Rubrik PowerShell SDK.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using RubrikSecurityCloud;

namespace RubrikSecurityCloud.Types
{
    #region SapHanaSystemCopyConfigInput

    public class SapHanaSystemCopyConfigInput: IInput
    {
        #region members

        //      C# -> System.String? SourceDbId
        // GraphQL -> sourceDbId: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("sourceDbId")]
        public System.String? SourceDbId { get; set; }

        //      C# -> System.String? TargetDbId
        // GraphQL -> targetDbId: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("targetDbId")]
        public System.String? TargetDbId { get; set; }


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

    } // class SapHanaSystemCopyConfigInput
    #endregion

} // namespace RubrikSecurityCloud.Types