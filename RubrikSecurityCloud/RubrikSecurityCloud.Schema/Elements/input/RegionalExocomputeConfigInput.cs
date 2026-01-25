// RegionalExocomputeConfigInput.cs
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
    #region RegionalExocomputeConfigInput

    public class RegionalExocomputeConfigInput: IInput
    {
        #region members

        //      C# -> System.String? VpcNetworkName
        // GraphQL -> vpcNetworkName: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("vpcNetworkName")]
        public System.String? VpcNetworkName { get; set; }

        //      C# -> GcpCloudAccountRegion? Region
        // GraphQL -> region: GcpCloudAccountRegion! (enum)
        [Required]
        [JsonRequired]
        [JsonProperty("region")]
        public GcpCloudAccountRegion? Region { get; set; }

        //      C# -> System.String? SubnetName
        // GraphQL -> subnetName: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("subnetName")]
        public System.String? SubnetName { get; set; }

        //      C# -> System.String? ProjectId
        // GraphQL -> projectId: String (scalar)
        [JsonProperty("projectId")]
        public System.String? ProjectId { get; set; }


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

    } // class RegionalExocomputeConfigInput
    #endregion

} // namespace RubrikSecurityCloud.Types