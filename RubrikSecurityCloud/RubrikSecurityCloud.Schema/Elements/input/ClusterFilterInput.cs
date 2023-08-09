// ClusterFilterInput.cs
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
    #region ClusterFilterInput

    public class ClusterFilterInput: IInput
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

        //      C# -> List<ObjectTypeEnum>? ObjectType
        // GraphQL -> objectType: [ObjectTypeEnum!] (enum)
        [JsonProperty("objectType")]
        public List<ObjectTypeEnum>? ObjectType { get; set; }

        //      C# -> DateTime? RegistrationtimeGt
        // GraphQL -> registrationTime_gt: DateTime (scalar)
        [JsonProperty("registrationTime_gt")]
        public DateTime? RegistrationtimeGt { get; set; }

        //      C# -> DateTime? RegistrationtimeLt
        // GraphQL -> registrationTime_lt: DateTime (scalar)
        [JsonProperty("registrationTime_lt")]
        public DateTime? RegistrationtimeLt { get; set; }

        //      C# -> System.String? MinSoftwareVersion
        // GraphQL -> minSoftwareVersion: String (scalar)
        [JsonProperty("minSoftwareVersion")]
        public System.String? MinSoftwareVersion { get; set; }

        //      C# -> List<System.String>? ClusterLocation
        // GraphQL -> clusterLocation: [String!] (scalar)
        [JsonProperty("clusterLocation")]
        public List<System.String>? ClusterLocation { get; set; }

        //      C# -> System.Boolean? ExcludeEmptyCluster
        // GraphQL -> excludeEmptyCluster: Boolean (scalar)
        [JsonProperty("excludeEmptyCluster")]
        public System.Boolean? ExcludeEmptyCluster { get; set; }

        //      C# -> List<ClusterProductEnum>? ProductType
        // GraphQL -> productType: [ClusterProductEnum!] (enum)
        [JsonProperty("productType")]
        public List<ClusterProductEnum>? ProductType { get; set; }

        //      C# -> List<ClusterRegistrationMode>? RegisteredMode
        // GraphQL -> registeredMode: [ClusterRegistrationMode!] (enum)
        [JsonProperty("registeredMode")]
        public List<ClusterRegistrationMode>? RegisteredMode { get; set; }

        //      C# -> Product? Product
        // GraphQL -> product: Product (enum)
        [JsonProperty("product")]
        public Product? Product { get; set; }

        //      C# -> List<System.String>? OrgId
        // GraphQL -> orgId: [UUID!] (scalar)
        [JsonProperty("orgId")]
        public List<System.String>? OrgId { get; set; }

        //      C# -> List<ClusterFilterPerProductInput>? ProductFilters
        // GraphQL -> productFilters: [ClusterFilterPerProductInput!] (input)
        [JsonProperty("productFilters")]
        public List<ClusterFilterPerProductInput>? ProductFilters { get; set; }

        //      C# -> List<System.String>? ExcludeId
        // GraphQL -> excludeId: [UUID!] (scalar)
        [JsonProperty("excludeId")]
        public List<System.String>? ExcludeId { get; set; }

        //      C# -> List<ClusterSystemStatus>? SystemStatus
        // GraphQL -> systemStatus: [ClusterSystemStatus!] (enum)
        [JsonProperty("systemStatus")]
        public List<ClusterSystemStatus>? SystemStatus { get; set; }

        //      C# -> List<ClusterStatus>? ConnectionState
        // GraphQL -> connectionState: [ClusterStatus!] (enum)
        [JsonProperty("connectionState")]
        public List<ClusterStatus>? ConnectionState { get; set; }

        //      C# -> System.Boolean? IsInFatalOrDisconnectedState
        // GraphQL -> isInFatalOrDisconnectedState: Boolean (scalar)
        [JsonProperty("isInFatalOrDisconnectedState")]
        public System.Boolean? IsInFatalOrDisconnectedState { get; set; }


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

    } // class ClusterFilterInput
    #endregion

} // namespace RubrikSecurityCloud.Types