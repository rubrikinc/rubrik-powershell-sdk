// HostVfdInstallRequestInput.cs
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
    #region HostVfdInstallRequestInput

    public class HostVfdInstallRequestInput: IInput
    {
        #region members

        //      C# -> List<System.String>? HostIds
        // GraphQL -> hostIds: [String!]! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("hostIds")]
        public List<System.String>? HostIds { get; set; }

        //      C# -> System.Boolean? Install
        // GraphQL -> install: Boolean! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("install")]
        public System.Boolean? Install { get; set; }


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

    } // class HostVfdInstallRequestInput
    #endregion

} // namespace Rubrik.SecurityCloud.Types