// NutanixVmRecoverySpecInput.cs
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
    #region NutanixVmRecoverySpecInput

    public class NutanixVmRecoverySpecInput: IInput
    {
        #region members

        //      C# -> System.Int64? Vcpus
        // GraphQL -> vCpus: Long (scalar)
        [JsonProperty("vCpus")]
        public System.Int64? Vcpus { get; set; }

        //      C# -> System.Int64? MemoryMbs
        // GraphQL -> memoryMbs: Long (scalar)
        [JsonProperty("memoryMbs")]
        public System.Int64? MemoryMbs { get; set; }

        //      C# -> System.String? ClusterId
        // GraphQL -> clusterId: String (scalar)
        [JsonProperty("clusterId")]
        public System.String? ClusterId { get; set; }

        //      C# -> System.Boolean? RemoveAllNetwork
        // GraphQL -> removeAllNetwork: Boolean (scalar)
        [JsonProperty("removeAllNetwork")]
        public System.Boolean? RemoveAllNetwork { get; set; }

        //      C# -> System.Boolean? PreserveMacAddress
        // GraphQL -> preserveMacAddress: Boolean (scalar)
        [JsonProperty("preserveMacAddress")]
        public System.Boolean? PreserveMacAddress { get; set; }

        //      C# -> List<NutanixVmVolumeSpecInput>? Volumes
        // GraphQL -> volumes: [NutanixVmVolumeSpecInput!] (input)
        [JsonProperty("volumes")]
        public List<NutanixVmVolumeSpecInput>? Volumes { get; set; }

        //      C# -> List<NutanixVmNicSpecInput>? Nics
        // GraphQL -> nics: [NutanixVmNicSpecInput!] (input)
        [JsonProperty("nics")]
        public List<NutanixVmNicSpecInput>? Nics { get; set; }

        //      C# -> NutanixComputeTargetInput? Target
        // GraphQL -> target: NutanixComputeTargetInput (input)
        [JsonProperty("target")]
        public NutanixComputeTargetInput? Target { get; set; }


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

    } // class NutanixVmRecoverySpecInput
    #endregion

} // namespace RubrikSecurityCloud.Types