// FilesetUpdateInput.cs
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
    #region FilesetUpdateInput

    public class FilesetUpdateInput: IInput
    {
        #region members

        //      C# -> System.String? ConfiguredSlaDomainId
        // GraphQL -> configuredSlaDomainId: String (scalar)
        [JsonProperty("configuredSlaDomainId")]
        public System.String? ConfiguredSlaDomainId { get; set; }

        //      C# -> System.Boolean? ForceFull
        // GraphQL -> forceFull: Boolean (scalar)
        [JsonProperty("forceFull")]
        public System.Boolean? ForceFull { get; set; }

        //      C# -> List<System.Int32>? ForceFullPartitionIds
        // GraphQL -> forceFullPartitionIds: [Int!] (scalar)
        [JsonProperty("forceFullPartitionIds")]
        public List<System.Int32>? ForceFullPartitionIds { get; set; }

        //      C# -> System.String? SnapMirrorLabelForFullBackup
        // GraphQL -> snapMirrorLabelForFullBackup: String (scalar)
        [JsonProperty("snapMirrorLabelForFullBackup")]
        public System.String? SnapMirrorLabelForFullBackup { get; set; }

        //      C# -> System.String? SnapMirrorLabelForIncrementalBackup
        // GraphQL -> snapMirrorLabelForIncrementalBackup: String (scalar)
        [JsonProperty("snapMirrorLabelForIncrementalBackup")]
        public System.String? SnapMirrorLabelForIncrementalBackup { get; set; }


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

    } // class FilesetUpdateInput
    #endregion

} // namespace RubrikSecurityCloud.Types