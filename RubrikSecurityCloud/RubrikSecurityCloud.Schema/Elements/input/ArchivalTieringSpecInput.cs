// ArchivalTieringSpecInput.cs
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
    #region ArchivalTieringSpecInput

    public class ArchivalTieringSpecInput: IInput
    {
        #region members

        //      C# -> System.Boolean? IsInstantTieringEnabled
        // GraphQL -> isInstantTieringEnabled: Boolean (scalar)
        [JsonProperty("isInstantTieringEnabled")]
        public System.Boolean? IsInstantTieringEnabled { get; set; }

        //      C# -> System.Int64? MinAccessibleDurationInSeconds
        // GraphQL -> minAccessibleDurationInSeconds: Long (scalar)
        [JsonProperty("minAccessibleDurationInSeconds")]
        public System.Int64? MinAccessibleDurationInSeconds { get; set; }

        //      C# -> ColdStorageClass? ColdStorageClass
        // GraphQL -> coldStorageClass: ColdStorageClass (enum)
        [JsonProperty("coldStorageClass")]
        public ColdStorageClass? ColdStorageClass { get; set; }

        //      C# -> System.Boolean? ShouldTierExistingSnapshots
        // GraphQL -> shouldTierExistingSnapshots: Boolean (scalar)
        [JsonProperty("shouldTierExistingSnapshots")]
        public System.Boolean? ShouldTierExistingSnapshots { get; set; }


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

    } // class ArchivalTieringSpecInput
    #endregion

} // namespace RubrikSecurityCloud.Types