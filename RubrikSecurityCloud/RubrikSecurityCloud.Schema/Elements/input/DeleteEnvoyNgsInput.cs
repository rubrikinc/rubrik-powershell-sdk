// DeleteEnvoyNgsInput.cs
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
    #region DeleteEnvoyNgsInput

    public class DeleteEnvoyNgsInput: IInput
    {
        #region members

        //      C# -> System.String? OrgNetworkId
        // GraphQL -> orgNetworkID: UUID! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("orgNetworkID")]
        public System.String? OrgNetworkId { get; set; }

        //      C# -> List<System.String>? EnvoyIds
        // GraphQL -> envoyIds: [String!]! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("envoyIds")]
        public List<System.String>? EnvoyIds { get; set; }

        //      C# -> System.String? ClusterUuid
        // GraphQL -> clusterUuid: UUID! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("clusterUuid")]
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

    } // class DeleteEnvoyNgsInput
    #endregion

} // namespace RubrikSecurityCloud.Types