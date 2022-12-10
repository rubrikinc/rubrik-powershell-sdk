// MssqlSlaPatchPropertiesInput.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:04:30.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Rubrik.SecurityCloud.Types
{
    #region MssqlSlaPatchPropertiesInput

    public class MssqlSlaPatchPropertiesInput
    {
        #region members
        //      C# -> System.String? ConfiguredSlaDomainId
        // GraphQL -> configuredSlaDomainId: String (scalar)
        [JsonProperty("configuredSlaDomainId")]
        public System.String? ConfiguredSlaDomainId { get; set; }

        //      C# -> System.Boolean? UseConfiguredDefaultLogRetention
        // GraphQL -> useConfiguredDefaultLogRetention: Boolean (scalar)
        [JsonProperty("useConfiguredDefaultLogRetention")]
        public System.Boolean? UseConfiguredDefaultLogRetention { get; set; }

        //      C# -> MssqlSlaRelatedPropertiesInput? MssqlSlaRelatedProperties
        // GraphQL -> mssqlSlaRelatedProperties: MssqlSlaRelatedPropertiesInput (input)
        [JsonProperty("mssqlSlaRelatedProperties")]
        public MssqlSlaRelatedPropertiesInput? MssqlSlaRelatedProperties { get; set; }

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

    } // class MssqlSlaPatchPropertiesInput
    #endregion

} // namespace Rubrik.SecurityCloud.Types