// HypervStandaloneTargetInput.cs
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
    #region HypervStandaloneTargetInput

    public class HypervStandaloneTargetInput: IInput
    {
        #region members

        //      C# -> System.String? HostId
        // GraphQL -> hostId: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("hostId")]
        public System.String? HostId { get; set; }

        //      C# -> System.String? HostName
        // GraphQL -> hostName: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("hostName")]
        public System.String? HostName { get; set; }

        //      C# -> System.String? ExportPath
        // GraphQL -> exportPath: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("exportPath")]
        public System.String? ExportPath { get; set; }

        //      C# -> List<HypervStandaloneNicSpecInput>? Nics
        // GraphQL -> nics: [HypervStandaloneNicSpecInput!] (input)
        [JsonProperty("nics")]
        public List<HypervStandaloneNicSpecInput>? Nics { get; set; }


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

    } // class HypervStandaloneTargetInput
    #endregion

} // namespace RubrikSecurityCloud.Types