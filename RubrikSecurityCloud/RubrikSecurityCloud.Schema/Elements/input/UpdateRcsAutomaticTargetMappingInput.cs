// UpdateRcsAutomaticTargetMappingInput.cs
//
// This generated file is part of the Rubrik PowerShell SDK.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Rubrik.SecurityCloud.Types
{
    #region UpdateRcsAutomaticTargetMappingInput

    public class UpdateRcsAutomaticTargetMappingInput: IInput
    {
        #region members

        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> System.Int64? LockDurationDays
        // GraphQL -> lockDurationDays: Long! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("lockDurationDays")]
        public System.Int64? LockDurationDays { get; set; }

        //      C# -> List<System.String>? ClusterUuidList
        // GraphQL -> clusterUuidList: [String!] (scalar)
        [JsonProperty("clusterUuidList")]
        public List<System.String>? ClusterUuidList { get; set; }


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

    } // class UpdateRcsAutomaticTargetMappingInput
    #endregion

} // namespace Rubrik.SecurityCloud.Types