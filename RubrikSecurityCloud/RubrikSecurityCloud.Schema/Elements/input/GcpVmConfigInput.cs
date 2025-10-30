// GcpVmConfigInput.cs
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
    #region GcpVmConfigInput

    public class GcpVmConfigInput: IInput
    {
        #region members

        //      C# -> System.String? CdmVersion
        // GraphQL -> cdmVersion: String (scalar)
        [JsonProperty("cdmVersion")]
        public System.String? CdmVersion { get; set; }

        //      C# -> VmType? VmType
        // GraphQL -> vmType: VmType (enum)
        [JsonProperty("vmType")]
        public VmType? VmType { get; set; }

        //      C# -> System.Int32? NodeSizeGb
        // GraphQL -> nodeSizeGb: Int (scalar)
        [JsonProperty("nodeSizeGb")]
        public System.Int32? NodeSizeGb { get; set; }

        //      C# -> System.String? ImageId
        // GraphQL -> imageId: String (scalar)
        [JsonProperty("imageId")]
        public System.String? ImageId { get; set; }

        //      C# -> System.String? Labels
        // GraphQL -> labels: String (scalar)
        [JsonProperty("labels")]
        public System.String? Labels { get; set; }

        //      C# -> List<GcpServiceAccountInput>? ServiceAccounts
        // GraphQL -> serviceAccounts: [GcpServiceAccountInput!] (input)
        [JsonProperty("serviceAccounts")]
        public List<GcpServiceAccountInput>? ServiceAccounts { get; set; }

        //      C# -> GcpInstanceType? InstanceType
        // GraphQL -> instanceType: GcpInstanceType (enum)
        [JsonProperty("instanceType")]
        public GcpInstanceType? InstanceType { get; set; }

        //      C# -> System.Boolean? DeleteProtection
        // GraphQL -> deleteProtection: Boolean (scalar)
        [JsonProperty("deleteProtection")]
        public System.Boolean? DeleteProtection { get; set; }

        //      C# -> List<GcpSubnetInput>? NetworkConfig
        // GraphQL -> networkConfig: [GcpSubnetInput!] (input)
        [JsonProperty("networkConfig")]
        public List<GcpSubnetInput>? NetworkConfig { get; set; }

        //      C# -> GcpTestImage? TestImage
        // GraphQL -> testImage: GcpTestImage (input)
        [JsonProperty("testImage")]
        public GcpTestImage? TestImage { get; set; }


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

    } // class GcpVmConfigInput
    #endregion

} // namespace RubrikSecurityCloud.Types