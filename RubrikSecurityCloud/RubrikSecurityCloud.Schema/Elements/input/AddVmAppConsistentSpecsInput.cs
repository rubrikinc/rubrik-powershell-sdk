// AddVmAppConsistentSpecsInput.cs
//
// This generated file is part of the Rubrik PowerShell SDK.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Rubrik.SecurityCloud.Types
{
    #region AddVmAppConsistentSpecsInput

    public class AddVmAppConsistentSpecsInput: IInput
    {
        #region members

        //      C# -> List<System.String>? SnappableIds
        // GraphQL -> snappableIds: [UUID!]! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("snappableIds")]
        public List<System.String>? SnappableIds { get; set; }

        //      C# -> System.String? PreSnapshotScriptPath
        // GraphQL -> preSnapshotScriptPath: String (scalar)
        [JsonProperty("preSnapshotScriptPath")]
        public System.String? PreSnapshotScriptPath { get; set; }

        //      C# -> System.Int32? PreSnapshotScriptTimeoutInSeconds
        // GraphQL -> preSnapshotScriptTimeoutInSeconds: Int (scalar)
        [JsonProperty("preSnapshotScriptTimeoutInSeconds")]
        public System.Int32? PreSnapshotScriptTimeoutInSeconds { get; set; }

        //      C# -> System.String? PostSnapshotScriptPath
        // GraphQL -> postSnapshotScriptPath: String (scalar)
        [JsonProperty("postSnapshotScriptPath")]
        public System.String? PostSnapshotScriptPath { get; set; }

        //      C# -> System.Int32? PostSnapshotScriptTimeoutInSeconds
        // GraphQL -> postSnapshotScriptTimeoutInSeconds: Int (scalar)
        [JsonProperty("postSnapshotScriptTimeoutInSeconds")]
        public System.Int32? PostSnapshotScriptTimeoutInSeconds { get; set; }

        //      C# -> System.Boolean? CancelBackupIfPreScriptFails
        // GraphQL -> cancelBackupIfPreScriptFails: Boolean! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("cancelBackupIfPreScriptFails")]
        public System.Boolean? CancelBackupIfPreScriptFails { get; set; }

        //      C# -> CloudNativeVmAppConsistentObjectType? ObjectType
        // GraphQL -> objectType: CloudNativeVmAppConsistentObjectType! (enum)
        [Required]
        [JsonRequired]
        [JsonProperty("objectType")]
        public CloudNativeVmAppConsistentObjectType? ObjectType { get; set; }


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

    } // class AddVmAppConsistentSpecsInput
    #endregion

} // namespace Rubrik.SecurityCloud.Types