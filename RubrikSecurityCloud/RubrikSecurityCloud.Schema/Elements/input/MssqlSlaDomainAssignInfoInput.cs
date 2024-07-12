// MssqlSlaDomainAssignInfoInput.cs
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
    #region MssqlSlaDomainAssignInfoInput

    public class MssqlSlaDomainAssignInfoInput: IInput
    {
        #region members

        //      C# -> System.Boolean? ShouldApplyToExistingSnapshots
        // GraphQL -> shouldApplyToExistingSnapshots: Boolean (scalar)
        [JsonProperty("shouldApplyToExistingSnapshots")]
        public System.Boolean? ShouldApplyToExistingSnapshots { get; set; }

        //      C# -> System.Boolean? ShouldApplyToNonPolicySnapshots
        // GraphQL -> shouldApplyToNonPolicySnapshots: Boolean (scalar)
        [JsonProperty("shouldApplyToNonPolicySnapshots")]
        public System.Boolean? ShouldApplyToNonPolicySnapshots { get; set; }

        //      C# -> ExistingSnapshotRetention? ExistingSnapshotRetention
        // GraphQL -> existingSnapshotRetention: ExistingSnapshotRetention (enum)
        [JsonProperty("existingSnapshotRetention")]
        public ExistingSnapshotRetention? ExistingSnapshotRetention { get; set; }

        //      C# -> List<System.String>? Ids
        // GraphQL -> ids: [String!]! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("ids")]
        public List<System.String>? Ids { get; set; }

        //      C# -> MssqlSlaPatchPropertiesInput? MssqlSlaPatchProperties
        // GraphQL -> mssqlSlaPatchProperties: MssqlSlaPatchPropertiesInput (input)
        [JsonProperty("mssqlSlaPatchProperties")]
        public MssqlSlaPatchPropertiesInput? MssqlSlaPatchProperties { get; set; }


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

    } // class MssqlSlaDomainAssignInfoInput
    #endregion

} // namespace RubrikSecurityCloud.Types