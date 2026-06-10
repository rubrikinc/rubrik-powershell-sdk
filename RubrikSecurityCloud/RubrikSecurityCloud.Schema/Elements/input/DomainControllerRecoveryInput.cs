// DomainControllerRecoveryInput.cs
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
    #region DomainControllerRecoveryInput

    public class DomainControllerRecoveryInput: IInput
    {
        #region members

        //      C# -> System.String? SnapshotId
        // GraphQL -> snapshotId: UUID! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("snapshotId")]
        public System.String? SnapshotId { get; set; }

        //      C# -> System.String? AltHostId
        // GraphQL -> altHostId: UUID (scalar)
        [JsonProperty("altHostId")]
        public System.String? AltHostId { get; set; }

        //      C# -> DcRecoveryMethod? RecoveryMethod
        // GraphQL -> recoveryMethod: DcRecoveryMethod (enum)
        [JsonProperty("recoveryMethod")]
        public DcRecoveryMethod? RecoveryMethod { get; set; }

        //      C# -> UnselectedDcBehavior? UnselectedDcBehavior
        // GraphQL -> unselectedDcBehavior: UnselectedDcBehavior (enum)
        [JsonProperty("unselectedDcBehavior")]
        public UnselectedDcBehavior? UnselectedDcBehavior { get; set; }

        //      C# -> NetworkInterfaceSetting? NetworkInterfaceSetting
        // GraphQL -> networkInterfaceSetting: NetworkInterfaceSetting (enum)
        [JsonProperty("networkInterfaceSetting")]
        public NetworkInterfaceSetting? NetworkInterfaceSetting { get; set; }

        //      C# -> System.String? DsrmPassword
        // GraphQL -> dsrmPassword: String (scalar)
        [JsonProperty("dsrmPassword")]
        public System.String? DsrmPassword { get; set; }


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

    } // class DomainControllerRecoveryInput
    #endregion

} // namespace RubrikSecurityCloud.Types