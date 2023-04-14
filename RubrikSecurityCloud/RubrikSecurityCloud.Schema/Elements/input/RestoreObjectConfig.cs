// RestoreObjectConfig.cs
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
    #region RestoreObjectConfig

    public class RestoreObjectConfig: IInput
    {
        #region members

        //      C# -> System.String? SnapshotUuid
        // GraphQL -> SnapshotUUID: UUID! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("SnapshotUUID")]
        public System.String? SnapshotUuid { get; set; }

        //      C# -> System.String? EmailId
        // GraphQL -> EmailID: String (scalar)
        [JsonProperty("EmailID")]
        public System.String? EmailId { get; set; }

        //      C# -> System.String? FolderId
        // GraphQL -> FolderID: String (scalar)
        [JsonProperty("FolderID")]
        public System.String? FolderId { get; set; }


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

    } // class RestoreObjectConfig
    #endregion

} // namespace Rubrik.SecurityCloud.Types