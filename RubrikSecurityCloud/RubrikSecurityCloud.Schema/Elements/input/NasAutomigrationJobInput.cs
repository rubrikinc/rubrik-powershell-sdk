// NasAutomigrationJobInput.cs
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
    #region NasAutomigrationJobInput

    public class NasAutomigrationJobInput: IInput
    {
        #region members

        //      C# -> System.Boolean? MigrateAllHosts
        // GraphQL -> MigrateAllHosts: Boolean! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("MigrateAllHosts")]
        public System.Boolean? MigrateAllHosts { get; set; }

        //      C# -> List<System.String>? CopyableHostIds
        // GraphQL -> CopyableHostIDs: [UUID!]! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("CopyableHostIDs")]
        public List<System.String>? CopyableHostIds { get; set; }

        //      C# -> List<System.String>? NasSystemIds
        // GraphQL -> NasSystemIDs: [UUID!]! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("NasSystemIDs")]
        public List<System.String>? NasSystemIds { get; set; }

        //      C# -> System.String? ClusterUuid
        // GraphQL -> clusterUUID: UUID (scalar)
        [JsonProperty("clusterUUID")]
        public System.String? ClusterUuid { get; set; }


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

    } // class NasAutomigrationJobInput
    #endregion

} // namespace RubrikSecurityCloud.Types