// HdfsBaseConfigInput.cs
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
    #region HdfsBaseConfigInput

    public class HdfsBaseConfigInput: IInput
    {
        #region members

        //      C# -> System.String? ApiToken
        // GraphQL -> apiToken: String (scalar)
        [JsonProperty("apiToken")]
        public System.String? ApiToken { get; set; }

        //      C# -> System.String? KerberosTicket
        // GraphQL -> kerberosTicket: String (scalar)
        [JsonProperty("kerberosTicket")]
        public System.String? KerberosTicket { get; set; }

        //      C# -> System.String? Nameservices
        // GraphQL -> nameservices: String (scalar)
        [JsonProperty("nameservices")]
        public System.String? Nameservices { get; set; }

        //      C# -> System.String? Username
        // GraphQL -> username: String (scalar)
        [JsonProperty("username")]
        public System.String? Username { get; set; }

        //      C# -> List<HdfsHostInput>? Hosts
        // GraphQL -> hosts: [HdfsHostInput!]! (input)
        [Required]
        [JsonRequired]
        [JsonProperty("hosts")]
        public List<HdfsHostInput>? Hosts { get; set; }


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

    } // class HdfsBaseConfigInput
    #endregion

} // namespace Rubrik.SecurityCloud.Types