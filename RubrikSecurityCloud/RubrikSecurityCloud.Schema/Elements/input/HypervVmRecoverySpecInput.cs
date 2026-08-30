// HypervVmRecoverySpecInput.cs
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
    #region HypervVmRecoverySpecInput

    public class HypervVmRecoverySpecInput: IInput
    {
        #region members

        //      C# -> System.Int32? Vcpus
        // GraphQL -> vCpus: Int (scalar)
        [JsonProperty("vCpus")]
        public System.Int32? Vcpus { get; set; }

        //      C# -> System.Int64? MemoryMbs
        // GraphQL -> memoryMbs: Long (scalar)
        [JsonProperty("memoryMbs")]
        public System.Int64? MemoryMbs { get; set; }

        //      C# -> NetworkPreservationMode? NetworkMode
        // GraphQL -> networkMode: NetworkPreservationMode (enum)
        [JsonProperty("networkMode")]
        public NetworkPreservationMode? NetworkMode { get; set; }

        //      C# -> System.Boolean? ShouldDisconnectNetwork
        // GraphQL -> shouldDisconnectNetwork: Boolean (scalar)
        [JsonProperty("shouldDisconnectNetwork")]
        public System.Boolean? ShouldDisconnectNetwork { get; set; }

        //      C# -> HypervTargetConfigInput? TargetConfig
        // GraphQL -> targetConfig: HypervTargetConfigInput (input)
        [JsonProperty("targetConfig")]
        public HypervTargetConfigInput? TargetConfig { get; set; }


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

    } // class HypervVmRecoverySpecInput
    #endregion

} // namespace RubrikSecurityCloud.Types