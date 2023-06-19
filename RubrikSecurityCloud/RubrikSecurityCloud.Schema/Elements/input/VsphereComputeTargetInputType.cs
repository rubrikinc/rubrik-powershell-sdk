// VsphereComputeTargetInputType.cs
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
    #region VsphereComputeTargetInputType

    public class VsphereComputeTargetInputType: IInput
    {
        #region members

        //      C# -> System.String? VcenterId
        // GraphQL -> vcenterId: String (scalar)
        [JsonProperty("vcenterId")]
        public System.String? VcenterId { get; set; }

        //      C# -> System.String? VcenterName
        // GraphQL -> vcenterName: String (scalar)
        [JsonProperty("vcenterName")]
        public System.String? VcenterName { get; set; }

        //      C# -> System.String? VcenterCdmId
        // GraphQL -> vcenterCdmId: String (scalar)
        [JsonProperty("vcenterCdmId")]
        public System.String? VcenterCdmId { get; set; }

        //      C# -> System.String? ComputeClusterId
        // GraphQL -> computeClusterId: String (scalar)
        [JsonProperty("computeClusterId")]
        public System.String? ComputeClusterId { get; set; }

        //      C# -> System.String? ComputeClusterCdmId
        // GraphQL -> computeClusterCdmId: String (scalar)
        [JsonProperty("computeClusterCdmId")]
        public System.String? ComputeClusterCdmId { get; set; }

        //      C# -> System.String? ComputeClusterName
        // GraphQL -> computeClusterName: String (scalar)
        [JsonProperty("computeClusterName")]
        public System.String? ComputeClusterName { get; set; }

        //      C# -> System.String? ResourcePoolId
        // GraphQL -> resourcePoolId: String (scalar)
        [JsonProperty("resourcePoolId")]
        public System.String? ResourcePoolId { get; set; }

        //      C# -> System.String? ResourcePoolCdmId
        // GraphQL -> resourcePoolCdmId: String (scalar)
        [JsonProperty("resourcePoolCdmId")]
        public System.String? ResourcePoolCdmId { get; set; }

        //      C# -> System.String? ResourcePoolName
        // GraphQL -> resourcePoolName: String (scalar)
        [JsonProperty("resourcePoolName")]
        public System.String? ResourcePoolName { get; set; }

        //      C# -> System.String? HostId
        // GraphQL -> hostId: String (scalar)
        [JsonProperty("hostId")]
        public System.String? HostId { get; set; }

        //      C# -> System.String? HostName
        // GraphQL -> hostName: String (scalar)
        [JsonProperty("hostName")]
        public System.String? HostName { get; set; }

        //      C# -> System.String? HostCdmId
        // GraphQL -> hostCdmId: String (scalar)
        [JsonProperty("hostCdmId")]
        public System.String? HostCdmId { get; set; }

        //      C# -> System.String? DatacenterId
        // GraphQL -> datacenterId: String (scalar)
        [JsonProperty("datacenterId")]
        public System.String? DatacenterId { get; set; }

        //      C# -> System.String? DatacenterCdmId
        // GraphQL -> datacenterCdmId: String (scalar)
        [JsonProperty("datacenterCdmId")]
        public System.String? DatacenterCdmId { get; set; }

        //      C# -> System.String? DatacenterName
        // GraphQL -> datacenterName: String (scalar)
        [JsonProperty("datacenterName")]
        public System.String? DatacenterName { get; set; }


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

    } // class VsphereComputeTargetInputType
    #endregion

} // namespace RubrikSecurityCloud.Types