// MountExportSnapshotJobCommonOptionsInput.cs
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
    #region MountExportSnapshotJobCommonOptionsInput

    public class MountExportSnapshotJobCommonOptionsInput: IInput
    {
        #region members

        //      C# -> System.Boolean? DisableNetwork
        // GraphQL -> disableNetwork: Boolean (scalar)
        [JsonProperty("disableNetwork")]
        public System.Boolean? DisableNetwork { get; set; }

        //      C# -> System.Boolean? KeepMacAddresses
        // GraphQL -> keepMacAddresses: Boolean (scalar)
        [JsonProperty("keepMacAddresses")]
        public System.Boolean? KeepMacAddresses { get; set; }

        //      C# -> System.Boolean? PowerOn
        // GraphQL -> powerOn: Boolean (scalar)
        [JsonProperty("powerOn")]
        public System.Boolean? PowerOn { get; set; }

        //      C# -> System.Boolean? RemoveNetworkDevices
        // GraphQL -> removeNetworkDevices: Boolean (scalar)
        [JsonProperty("removeNetworkDevices")]
        public System.Boolean? RemoveNetworkDevices { get; set; }

        //      C# -> System.String? VmName
        // GraphQL -> vmName: String (scalar)
        [JsonProperty("vmName")]
        public System.String? VmName { get; set; }


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

    } // class MountExportSnapshotJobCommonOptionsInput
    #endregion

} // namespace RubrikSecurityCloud.Types