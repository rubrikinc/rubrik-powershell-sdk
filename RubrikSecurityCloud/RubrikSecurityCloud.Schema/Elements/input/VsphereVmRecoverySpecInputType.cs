// VsphereVmRecoverySpecInputType.cs
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
    #region VsphereVmRecoverySpecInputType

    public class VsphereVmRecoverySpecInputType: IInput
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

        //      C# -> List<VsphereVmVolumeSpecInputType>? Volumes
        // GraphQL -> volumes: [VSphereVMVolumeSpecInputType!] (input)
        [JsonProperty("volumes")]
        public List<VsphereVmVolumeSpecInputType>? Volumes { get; set; }

        //      C# -> List<VsphereVmNicSpecInputType>? Nics
        // GraphQL -> nics: [VSphereVMNicSpecInputType!] (input)
        [JsonProperty("nics")]
        public List<VsphereVmNicSpecInputType>? Nics { get; set; }

        //      C# -> System.Int64? Version
        // GraphQL -> version: Long (scalar)
        [JsonProperty("version")]
        public System.Int64? Version { get; set; }

        //      C# -> System.String? UserData
        // GraphQL -> userData: String (scalar)
        [JsonProperty("userData")]
        public System.String? UserData { get; set; }

        //      C# -> VsphereComputeTargetInputType? Target
        // GraphQL -> target: VSphereComputeTargetInputType (input)
        [JsonProperty("target")]
        public VsphereComputeTargetInputType? Target { get; set; }

        //      C# -> System.Boolean? EnableNetworkPreserve
        // GraphQL -> enableNetworkPreserve: Boolean (scalar)
        [JsonProperty("enableNetworkPreserve")]
        public System.Boolean? EnableNetworkPreserve { get; set; }

        //      C# -> System.Boolean? EnableMacPreserveOnly
        // GraphQL -> enableMacPreserveOnly: Boolean (scalar)
        [JsonProperty("enableMacPreserveOnly")]
        public System.Boolean? EnableMacPreserveOnly { get; set; }

        //      C# -> System.String? Email
        // GraphQL -> email: String (scalar)
        [JsonProperty("email")]
        public System.String? Email { get; set; }

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

    } // class VsphereVmRecoverySpecInputType
    #endregion

} // namespace RubrikSecurityCloud.Types