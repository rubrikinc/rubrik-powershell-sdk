// GenerateCsrInput.cs
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
    #region GenerateCsrInput

    public class GenerateCsrInput: IInput
    {
        #region members

        //      C# -> System.String? ClusterUuid
        // GraphQL -> clusterUuid: String (scalar)
        [JsonProperty("clusterUuid")]
        public System.String? ClusterUuid { get; set; }

        //      C# -> List<System.String>? Hostnames
        // GraphQL -> hostnames: [String!] (scalar)
        [JsonProperty("hostnames")]
        public List<System.String>? Hostnames { get; set; }

        //      C# -> System.String? Organization
        // GraphQL -> organization: String (scalar)
        [JsonProperty("organization")]
        public System.String? Organization { get; set; }

        //      C# -> System.String? OrganizationalUnit
        // GraphQL -> organizationalUnit: String (scalar)
        [JsonProperty("organizationalUnit")]
        public System.String? OrganizationalUnit { get; set; }

        //      C# -> System.String? Country
        // GraphQL -> country: String (scalar)
        [JsonProperty("country")]
        public System.String? Country { get; set; }

        //      C# -> System.String? State
        // GraphQL -> state: String (scalar)
        [JsonProperty("state")]
        public System.String? State { get; set; }

        //      C# -> System.String? City
        // GraphQL -> city: String (scalar)
        [JsonProperty("city")]
        public System.String? City { get; set; }

        //      C# -> System.String? Surname
        // GraphQL -> surname: String (scalar)
        [JsonProperty("surname")]
        public System.String? Surname { get; set; }

        //      C# -> System.String? EmailAddress
        // GraphQL -> emailAddress: String (scalar)
        [JsonProperty("emailAddress")]
        public System.String? EmailAddress { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }


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

    } // class GenerateCsrInput
    #endregion

} // namespace RubrikSecurityCloud.Types