// UnmanagedObjectsInput.cs
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
    #region UnmanagedObjectsInput

    public class UnmanagedObjectsInput: IInput
    {
        #region members

        //      C# -> System.String? ClusterUuid
        // GraphQL -> clusterUuid: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("clusterUuid")]
        public System.String? ClusterUuid { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> List<UnmanagedObjectAvailabilityFilter>? UnmanagedStatuses
        // GraphQL -> unmanagedStatuses: [UnmanagedObjectAvailabilityFilter!]! (enum)
        [Required]
        [JsonRequired]
        [JsonProperty("unmanagedStatuses")]
        public List<UnmanagedObjectAvailabilityFilter>? UnmanagedStatuses { get; set; }

        //      C# -> List<ManagedObjectType>? ObjectTypes
        // GraphQL -> objectTypes: [ManagedObjectType!]! (enum)
        [Required]
        [JsonRequired]
        [JsonProperty("objectTypes")]
        public List<ManagedObjectType>? ObjectTypes { get; set; }

        //      C# -> List<System.String>? RetentionSlaDomainIds
        // GraphQL -> retentionSlaDomainIds: [String!]! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("retentionSlaDomainIds")]
        public List<System.String>? RetentionSlaDomainIds { get; set; }

        //      C# -> UnmanagedObjectsSortParam? SortParam
        // GraphQL -> sortParam: UnmanagedObjectsSortParam (input)
        [JsonProperty("sortParam")]
        public UnmanagedObjectsSortParam? SortParam { get; set; }

        //      C# -> System.String? ObjectId
        // GraphQL -> objectId: String (scalar)
        [JsonProperty("objectId")]
        public System.String? ObjectId { get; set; }

        //      C# -> List<WorkloadRegionInput>? Regions
        // GraphQL -> regions: [WorkloadRegionInput!] (input)
        [JsonProperty("regions")]
        public List<WorkloadRegionInput>? Regions { get; set; }

        //      C# -> List<System.String>? CloudAccountIds
        // GraphQL -> cloudAccountIds: [String!] (scalar)
        [JsonProperty("cloudAccountIds")]
        public List<System.String>? CloudAccountIds { get; set; }

        //      C# -> CloudVendor? ManagedBy
        // GraphQL -> managedBy: CloudVendor (enum)
        [JsonProperty("managedBy")]
        public CloudVendor? ManagedBy { get; set; }


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

    } // class UnmanagedObjectsInput
    #endregion

} // namespace RubrikSecurityCloud.Types