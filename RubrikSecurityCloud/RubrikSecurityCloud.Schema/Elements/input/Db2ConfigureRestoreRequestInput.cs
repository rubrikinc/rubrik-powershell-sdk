// Db2ConfigureRestoreRequestInput.cs
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
    #region Db2ConfigureRestoreRequestInput

    public class Db2ConfigureRestoreRequestInput: IInput
    {
        #region members

        //      C# -> DateTime? ExpiryTimestamp
        // GraphQL -> expiryTimestamp: DateTime (scalar)
        [JsonProperty("expiryTimestamp")]
        public DateTime? ExpiryTimestamp { get; set; }

        //      C# -> List<System.String>? HostIdsToAdd
        // GraphQL -> hostIdsToAdd: [String!]! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("hostIdsToAdd")]
        public List<System.String>? HostIdsToAdd { get; set; }

        //      C# -> List<System.String>? HostIdsToRemove
        // GraphQL -> hostIdsToRemove: [String!]! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("hostIdsToRemove")]
        public List<System.String>? HostIdsToRemove { get; set; }


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

    } // class Db2ConfigureRestoreRequestInput
    #endregion

} // namespace RubrikSecurityCloud.Types