// ConfigProtectionInfoFilterInput.cs
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
    #region ConfigProtectionInfoFilterInput

    public class ConfigProtectionInfoFilterInput: IInput
    {
        #region members

        //      C# -> List<System.String>? Id
        // GraphQL -> id: [UUID!] (scalar)
        [JsonProperty("id")]
        public List<System.String>? Id { get; set; }

        //      C# -> List<System.String>? Name
        // GraphQL -> name: [String!] (scalar)
        [JsonProperty("name")]
        public List<System.String>? Name { get; set; }

        //      C# -> List<ClusterTypeEnum>? Type
        // GraphQL -> type: [ClusterTypeEnum!] (enum)
        [JsonProperty("type")]
        public List<ClusterTypeEnum>? Type { get; set; }

        //      C# -> System.String? MinSoftwareVersion
        // GraphQL -> minSoftwareVersion: String (scalar)
        [JsonProperty("minSoftwareVersion")]
        public System.String? MinSoftwareVersion { get; set; }

        //      C# -> List<System.String>? ClusterLocation
        // GraphQL -> clusterLocation: [String!] (scalar)
        [JsonProperty("clusterLocation")]
        public List<System.String>? ClusterLocation { get; set; }

        //      C# -> List<ClusterStatus>? ConnectionState
        // GraphQL -> connectionState: [ClusterStatus!] (enum)
        [JsonProperty("connectionState")]
        public List<ClusterStatus>? ConnectionState { get; set; }

        //      C# -> List<ClusterProductEnum>? ProductType
        // GraphQL -> productType: [ClusterProductEnum!] (enum)
        [JsonProperty("productType")]
        public List<ClusterProductEnum>? ProductType { get; set; }

        //      C# -> List<ConfigProtectionStatus>? ConfigProtectionStatus
        // GraphQL -> configProtectionStatus: [ConfigProtectionStatus!] (enum)
        [JsonProperty("configProtectionStatus")]
        public List<ConfigProtectionStatus>? ConfigProtectionStatus { get; set; }


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

    } // class ConfigProtectionInfoFilterInput
    #endregion

} // namespace Rubrik.SecurityCloud.Types