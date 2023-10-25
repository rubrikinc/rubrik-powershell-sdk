// AzureExocomputeAddConfigInputType.cs
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
    #region AzureExocomputeAddConfigInputType

    public class AzureExocomputeAddConfigInputType: IInput
    {
        #region members

        //      C# -> AzureCloudAccountRegion? Region
        // GraphQL -> region: AzureCloudAccountRegion! (enum)
        [Required]
        [JsonRequired]
        [JsonProperty("region")]
        public AzureCloudAccountRegion? Region { get; set; }

        //      C# -> System.String? SubnetNativeId
        // GraphQL -> subnetNativeId: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("subnetNativeId")]
        public System.String? SubnetNativeId { get; set; }

        //      C# -> System.Boolean? IsRscManaged
        // GraphQL -> isRscManaged: Boolean! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("isRscManaged")]
        public System.Boolean? IsRscManaged { get; set; }

        //      C# -> System.String? PodSubnetNativeId
        // GraphQL -> podSubnetNativeId: String (scalar)
        [JsonProperty("podSubnetNativeId")]
        public System.String? PodSubnetNativeId { get; set; }

        //      C# -> System.String? PodOverlayNetworkCidr
        // GraphQL -> podOverlayNetworkCidr: String (scalar)
        [JsonProperty("podOverlayNetworkCidr")]
        public System.String? PodOverlayNetworkCidr { get; set; }


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

    } // class AzureExocomputeAddConfigInputType
    #endregion

} // namespace RubrikSecurityCloud.Types