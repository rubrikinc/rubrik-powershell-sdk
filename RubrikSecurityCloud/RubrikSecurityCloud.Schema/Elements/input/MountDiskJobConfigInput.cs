// MountDiskJobConfigInput.cs
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
    #region MountDiskJobConfigInput

    public class MountDiskJobConfigInput: IInput
    {
        #region members

        //      C# -> System.String? TargetVmId
        // GraphQL -> targetVmId: String (scalar)
        [JsonProperty("targetVmId")]
        public System.String? TargetVmId { get; set; }

        //      C# -> System.Int32? Vlan
        // GraphQL -> vlan: Int (scalar)
        [JsonProperty("vlan")]
        public System.Int32? Vlan { get; set; }

        //      C# -> List<System.String>? VmdkIds
        // GraphQL -> vmdkIds: [String!] (scalar)
        [JsonProperty("vmdkIds")]
        public List<System.String>? VmdkIds { get; set; }

        //      C# -> System.Int64? UnmountTimeOpt
        // GraphQL -> unmountTimeOpt: Long (scalar)
        [JsonProperty("unmountTimeOpt")]
        public System.Int64? UnmountTimeOpt { get; set; }


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

    } // class MountDiskJobConfigInput
    #endregion

} // namespace RubrikSecurityCloud.Types