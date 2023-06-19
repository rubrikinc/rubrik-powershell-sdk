// MountSnapshotJobConfigV1Input.cs
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
    #region MountSnapshotJobConfigV1Input

    public class MountSnapshotJobConfigV1Input: IInput
    {
        #region members

        //      C# -> System.Boolean? CreateDatastoreOnly
        // GraphQL -> createDatastoreOnly: Boolean (scalar)
        [JsonProperty("createDatastoreOnly")]
        public System.Boolean? CreateDatastoreOnly { get; set; }

        //      C# -> System.String? DataStoreName
        // GraphQL -> dataStoreName: String (scalar)
        [JsonProperty("dataStoreName")]
        public System.String? DataStoreName { get; set; }

        //      C# -> System.String? HostId
        // GraphQL -> hostId: String (scalar)
        [JsonProperty("hostId")]
        public System.String? HostId { get; set; }

        //      C# -> System.Boolean? ShouldRecoverTags
        // GraphQL -> shouldRecoverTags: Boolean (scalar)
        [JsonProperty("shouldRecoverTags")]
        public System.Boolean? ShouldRecoverTags { get; set; }

        //      C# -> System.Int32? Vlan
        // GraphQL -> vlan: Int (scalar)
        [JsonProperty("vlan")]
        public System.Int32? Vlan { get; set; }

        //      C# -> MountExportSnapshotJobCommonOptionsInput? MountExportSnapshotJobCommonOptions
        // GraphQL -> mountExportSnapshotJobCommonOptions: MountExportSnapshotJobCommonOptionsInput (input)
        [JsonProperty("mountExportSnapshotJobCommonOptions")]
        public MountExportSnapshotJobCommonOptionsInput? MountExportSnapshotJobCommonOptions { get; set; }


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

    } // class MountSnapshotJobConfigV1Input
    #endregion

} // namespace RubrikSecurityCloud.Types