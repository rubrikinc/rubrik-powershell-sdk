// ActiveDirectoryRecoveryObjectInput.cs
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
    #region ActiveDirectoryRecoveryObjectInput

    public class ActiveDirectoryRecoveryObjectInput: IInput
    {
        #region members

        //      C# -> List<System.String>? Attributes
        // GraphQL -> attributes: [String!] (scalar)
        [JsonProperty("attributes")]
        public List<System.String>? Attributes { get; set; }

        //      C# -> ActiveDirectoryObjectType? ObjectType
        // GraphQL -> objectType: ActiveDirectoryObjectType (enum)
        [JsonProperty("objectType")]
        public ActiveDirectoryObjectType? ObjectType { get; set; }

        //      C# -> System.Int64? Dnt
        // GraphQL -> dnt: Long! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("dnt")]
        public System.Int64? Dnt { get; set; }


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

    } // class ActiveDirectoryRecoveryObjectInput
    #endregion

} // namespace RubrikSecurityCloud.Types