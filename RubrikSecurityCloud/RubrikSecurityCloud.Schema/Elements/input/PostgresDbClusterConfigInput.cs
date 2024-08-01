// PostgresDbClusterConfigInput.cs
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
    #region PostgresDbClusterConfigInput

    public class PostgresDbClusterConfigInput: IInput
    {
        #region members

        //      C# -> DiscoverableInputInput? DiscoveryInfo
        // GraphQL -> discoveryInfo: DiscoverableInputInput! (input)
        [Required]
        [JsonRequired]
        [JsonProperty("discoveryInfo")]
        public DiscoverableInputInput? DiscoveryInfo { get; set; }

        //      C# -> PostgresLoginInfoInput? LoginInfo
        // GraphQL -> loginInfo: PostgresLoginInfoInput (input)
        [JsonProperty("loginInfo")]
        public PostgresLoginInfoInput? LoginInfo { get; set; }

        //      C# -> System.String? SystemUsername
        // GraphQL -> systemUsername: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("systemUsername")]
        public System.String? SystemUsername { get; set; }


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

    } // class PostgresDbClusterConfigInput
    #endregion

} // namespace RubrikSecurityCloud.Types