// RestoreEntityInputInput.cs
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
    #region RestoreEntityInputInput

    public class RestoreEntityInputInput: IInput
    {
        #region members

        //      C# -> List<HostRecoveryTargetInput>? HostRecoveryTargets
        // GraphQL -> hostRecoveryTargets: [HostRecoveryTargetInput!]! (input)
        [Required]
        [JsonRequired]
        [JsonProperty("hostRecoveryTargets")]
        public List<HostRecoveryTargetInput>? HostRecoveryTargets { get; set; }

        //      C# -> RestoreLogSnapshotTimeRangeInput? LogSnapshotTimeRange
        // GraphQL -> logSnapshotTimeRange: RestoreLogSnapshotTimeRangeInput (input)
        [JsonProperty("logSnapshotTimeRange")]
        public RestoreLogSnapshotTimeRangeInput? LogSnapshotTimeRange { get; set; }

        //      C# -> System.String? SnapshotId
        // GraphQL -> snapshotId: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("snapshotId")]
        public System.String? SnapshotId { get; set; }


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

    } // class RestoreEntityInputInput
    #endregion

} // namespace RubrikSecurityCloud.Types