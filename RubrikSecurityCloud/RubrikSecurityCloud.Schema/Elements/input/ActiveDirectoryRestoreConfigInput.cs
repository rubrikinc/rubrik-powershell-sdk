// ActiveDirectoryRestoreConfigInput.cs
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
    #region ActiveDirectoryRestoreConfigInput

    public class ActiveDirectoryRestoreConfigInput: IInput
    {
        #region members

        //      C# -> System.String? SnapshotForAuthoritativeRestore
        // GraphQL -> snapshotForAuthoritativeRestore: String (scalar)
        [JsonProperty("snapshotForAuthoritativeRestore")]
        public System.String? SnapshotForAuthoritativeRestore { get; set; }

        //      C# -> List<DomainControllerRestoreConfigInput>? DomainControllerRestoreConfigs
        // GraphQL -> domainControllerRestoreConfigs: [DomainControllerRestoreConfigInput!]! (input)
        [Required]
        [JsonRequired]
        [JsonProperty("domainControllerRestoreConfigs")]
        public List<DomainControllerRestoreConfigInput>? DomainControllerRestoreConfigs { get; set; }

        //      C# -> System.Boolean? ShouldPerformAuthoritativeAdObjectsRestore
        // GraphQL -> shouldPerformAuthoritativeAdObjectsRestore: Boolean! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("shouldPerformAuthoritativeAdObjectsRestore")]
        public System.Boolean? ShouldPerformAuthoritativeAdObjectsRestore { get; set; }

        //      C# -> System.Boolean? ShouldPerformAuthoritativeSysvolRestore
        // GraphQL -> shouldPerformAuthoritativeSysvolRestore: Boolean! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("shouldPerformAuthoritativeSysvolRestore")]
        public System.Boolean? ShouldPerformAuthoritativeSysvolRestore { get; set; }


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

    } // class ActiveDirectoryRestoreConfigInput
    #endregion

} // namespace RubrikSecurityCloud.Types