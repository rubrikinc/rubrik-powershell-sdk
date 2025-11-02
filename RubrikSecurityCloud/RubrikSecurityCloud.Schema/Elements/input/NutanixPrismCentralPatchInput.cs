// NutanixPrismCentralPatchInput.cs
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
    #region NutanixPrismCentralPatchInput

    public class NutanixPrismCentralPatchInput: IInput
    {
        #region members

        //      C# -> System.String? CaCerts
        // GraphQL -> caCerts: String (scalar)
        [JsonProperty("caCerts")]
        public System.String? CaCerts { get; set; }

        //      C# -> System.String? ConfiguredSlaDomainId
        // GraphQL -> configuredSlaDomainId: String (scalar)
        [JsonProperty("configuredSlaDomainId")]
        public System.String? ConfiguredSlaDomainId { get; set; }

        //      C# -> System.String? Hostname
        // GraphQL -> hostname: String (scalar)
        [JsonProperty("hostname")]
        public System.String? Hostname { get; set; }

        //      C# -> System.String? Password
        // GraphQL -> password: String (scalar)
        [JsonProperty("password")]
        public System.String? Password { get; set; }

        //      C# -> System.String? Username
        // GraphQL -> username: String (scalar)
        [JsonProperty("username")]
        public System.String? Username { get; set; }

        //      C# -> List<NutanixClustersListElementInput>? DecommissionedNutanixClusters
        // GraphQL -> decommissionedNutanixClusters: [NutanixClustersListElementInput!] (input)
        [JsonProperty("decommissionedNutanixClusters")]
        public List<NutanixClustersListElementInput>? DecommissionedNutanixClusters { get; set; }

        //      C# -> System.Boolean? IsDrEnabled
        // GraphQL -> isDrEnabled: Boolean (scalar)
        [JsonProperty("isDrEnabled")]
        public System.Boolean? IsDrEnabled { get; set; }

        //      C# -> List<NutanixClustersListElementInput>? NutanixClusters
        // GraphQL -> nutanixClusters: [NutanixClustersListElementInput!] (input)
        [JsonProperty("nutanixClusters")]
        public List<NutanixClustersListElementInput>? NutanixClusters { get; set; }


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

    } // class NutanixPrismCentralPatchInput
    #endregion

} // namespace RubrikSecurityCloud.Types