// PureStorageProtectionGroupExportSnapshotJobConfigInput.cs
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
    #region PureStorageProtectionGroupExportSnapshotJobConfigInput

    public class PureStorageProtectionGroupExportSnapshotJobConfigInput: IInput
    {
        #region members

        //      C# -> System.String? ArrayId
        // GraphQL -> arrayId: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("arrayId")]
        public System.String? ArrayId { get; set; }

        //      C# -> System.String? ProtectionGroupName
        // GraphQL -> protectionGroupName: String (scalar)
        [JsonProperty("protectionGroupName")]
        public System.String? ProtectionGroupName { get; set; }

        //      C# -> List<System.String>? SnapshotVolumeIds
        // GraphQL -> snapshotVolumeIds: [String!] (scalar)
        [JsonProperty("snapshotVolumeIds")]
        public List<System.String>? SnapshotVolumeIds { get; set; }


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

    } // class PureStorageProtectionGroupExportSnapshotJobConfigInput
    #endregion

} // namespace RubrikSecurityCloud.Types