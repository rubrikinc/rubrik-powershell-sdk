// GcpNativeRestoreGceInstanceInput.cs
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
    #region GcpNativeRestoreGceInstanceInput

    public class GcpNativeRestoreGceInstanceInput: IInput
    {
        #region members

        //      C# -> System.String? SnapshotId
        // GraphQL -> snapshotId: UUID! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("snapshotId")]
        public System.String? SnapshotId { get; set; }

        //      C# -> System.Boolean? ShouldAddRubrikLabels
        // GraphQL -> shouldAddRubrikLabels: Boolean! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("shouldAddRubrikLabels")]
        public System.Boolean? ShouldAddRubrikLabels { get; set; }

        //      C# -> System.Boolean? ShouldRestoreLabels
        // GraphQL -> shouldRestoreLabels: Boolean! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("shouldRestoreLabels")]
        public System.Boolean? ShouldRestoreLabels { get; set; }

        //      C# -> System.Boolean? ShouldStartRestoredInstance
        // GraphQL -> shouldStartRestoredInstance: Boolean! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("shouldStartRestoredInstance")]
        public System.Boolean? ShouldStartRestoredInstance { get; set; }

        //      C# -> GcpSnapshotType? SnapshotType
        // GraphQL -> snapshotType: GcpSnapshotType (enum)
        [JsonProperty("snapshotType")]
        public GcpSnapshotType? SnapshotType { get; set; }


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

    } // class GcpNativeRestoreGceInstanceInput
    #endregion

} // namespace RubrikSecurityCloud.Types