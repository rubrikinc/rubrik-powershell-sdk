// HypervVirtualMachineUpdateInput.cs
//
// This generated file is part of the Rubrik PowerShell SDK.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using RubrikSecurityCloud.Schema.Utils;

namespace Rubrik.SecurityCloud.Types
{
    #region HypervVirtualMachineUpdateInput

    public class HypervVirtualMachineUpdateInput: IInput
    {
        #region members

        //      C# -> CloudInstantiationSpecInput? CloudInstantiationSpec
        // GraphQL -> cloudInstantiationSpec: CloudInstantiationSpecInput (input)
        [JsonProperty("cloudInstantiationSpec")]
        public CloudInstantiationSpecInput? CloudInstantiationSpec { get; set; }

        //      C# -> System.String? ConfiguredSlaDomainId
        // GraphQL -> configuredSlaDomainId: String (scalar)
        [JsonProperty("configuredSlaDomainId")]
        public System.String? ConfiguredSlaDomainId { get; set; }

        //      C# -> List<System.String>? VirtualDiskIdsExcludedFromSnapshot
        // GraphQL -> virtualDiskIdsExcludedFromSnapshot: [String!] (scalar)
        [JsonProperty("virtualDiskIdsExcludedFromSnapshot")]
        public List<System.String>? VirtualDiskIdsExcludedFromSnapshot { get; set; }


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

    } // class HypervVirtualMachineUpdateInput
    #endregion

} // namespace Rubrik.SecurityCloud.Types