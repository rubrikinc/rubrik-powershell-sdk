// VsphereVmRecoverySpecInput.cs
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
    #region VsphereVmRecoverySpecInput

    public class VsphereVmRecoverySpecInput: IInput
    {
        #region members

        //      C# -> System.Int32? Vcpus
        // GraphQL -> vcpus: Int (scalar)
        [JsonProperty("vcpus")]
        public System.Int32? Vcpus { get; set; }

        //      C# -> System.Int32? MemoryMbs
        // GraphQL -> memoryMbs: Int (scalar)
        [JsonProperty("memoryMbs")]
        public System.Int32? MemoryMbs { get; set; }

        //      C# -> List<VsphereVmVolumeSpecInput>? Volumes
        // GraphQL -> volumes: [VsphereVmVolumeSpecInput!] (input)
        [JsonProperty("volumes")]
        public List<VsphereVmVolumeSpecInput>? Volumes { get; set; }

        //      C# -> List<VsphereVmNicSpecInput>? Nics
        // GraphQL -> nics: [VsphereVmNicSpecInput!] (input)
        [JsonProperty("nics")]
        public List<VsphereVmNicSpecInput>? Nics { get; set; }

        //      C# -> System.String? PostScript
        // GraphQL -> postScript: String (scalar)
        [JsonProperty("postScript")]
        public System.String? PostScript { get; set; }

        //      C# -> VsphereComputeTargetInput? Target
        // GraphQL -> target: VsphereComputeTargetInput (input)
        [JsonProperty("target")]
        public VsphereComputeTargetInput? Target { get; set; }

        //      C# -> System.Boolean? EnableNetworkPreserve
        // GraphQL -> enableNetworkPreserve: Boolean (scalar)
        [JsonProperty("enableNetworkPreserve")]
        public System.Boolean? EnableNetworkPreserve { get; set; }

        //      C# -> System.Boolean? EnableMacPreserveOnly
        // GraphQL -> enableMacPreserveOnly: Boolean (scalar)
        [JsonProperty("enableMacPreserveOnly")]
        public System.Boolean? EnableMacPreserveOnly { get; set; }

        //      C# -> System.String? PostScriptTimestamp
        // GraphQL -> postScriptTimestamp: String (scalar)
        [JsonProperty("postScriptTimestamp")]
        public System.String? PostScriptTimestamp { get; set; }

        //      C# -> System.String? PostScriptHash
        // GraphQL -> postScriptHash: String (scalar)
        [JsonProperty("postScriptHash")]
        public System.String? PostScriptHash { get; set; }

        //      C# -> System.Boolean? EnableNetworkDisconnect
        // GraphQL -> enableNetworkDisconnect: Boolean (scalar)
        [JsonProperty("enableNetworkDisconnect")]
        public System.Boolean? EnableNetworkDisconnect { get; set; }

        //      C# -> System.String? LocalAdminPassword
        // GraphQL -> localAdminPassword: String (scalar)
        [JsonProperty("localAdminPassword")]
        public System.String? LocalAdminPassword { get; set; }


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

    } // class VsphereVmRecoverySpecInput
    #endregion

} // namespace RubrikSecurityCloud.Types