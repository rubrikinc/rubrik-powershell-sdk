// OrgNetworkFilterInput.cs
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
    #region OrgNetworkFilterInput

    public class OrgNetworkFilterInput: IInput
    {
        #region members

        //      C# -> System.String? Name
        // GraphQL -> name: String (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> List<System.String>? RubrikCluster
        // GraphQL -> rubrikCluster: [String!] (scalar)
        [JsonProperty("rubrikCluster")]
        public List<System.String>? RubrikCluster { get; set; }

        //      C# -> List<System.String>? MappedOrganization
        // GraphQL -> mappedOrganization: [String!] (scalar)
        [JsonProperty("mappedOrganization")]
        public List<System.String>? MappedOrganization { get; set; }

        //      C# -> List<EnvoyConnectionField>? EnvoyConnection
        // GraphQL -> envoyConnection: [EnvoyConnectionField] (enum)
        [JsonProperty("envoyConnection")]
        public List<EnvoyConnectionField>? EnvoyConnection { get; set; }


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

    } // class OrgNetworkFilterInput
    #endregion

} // namespace RubrikSecurityCloud.Types