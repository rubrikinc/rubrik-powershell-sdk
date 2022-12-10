// SharePointItems.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:04:32.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Rubrik.SecurityCloud.Types
{
    #region SharePointItems

    public class SharePointItems
    {
        #region members
        //      C# -> System.String? SharepointId
        // GraphQL -> sharepointId: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("sharepointId")]
        public System.String? SharepointId { get; set; }

        //      C# -> SnappableType? SnappableType
        // GraphQL -> snappableType: SnappableType (enum)
        [JsonProperty("snappableType")]
        public SnappableType? SnappableType { get; set; }

        //      C# -> List<SharePointListItem>? ListItems
        // GraphQL -> listItems: [SharePointListItem!]! (input)
        [Required]
        [JsonRequired]
        [JsonProperty("listItems")]
        public List<SharePointListItem>? ListItems { get; set; }

        //      C# -> List<FolderInfo>? FolderItems
        // GraphQL -> folderItems: [FolderInfo!]! (input)
        [Required]
        [JsonRequired]
        [JsonProperty("folderItems")]
        public List<FolderInfo>? FolderItems { get; set; }

        //      C# -> List<FileInfo>? FileItems
        // GraphQL -> fileItems: [FileInfo!]! (input)
        [Required]
        [JsonRequired]
        [JsonProperty("fileItems")]
        public List<FileInfo>? FileItems { get; set; }

        //      C# -> System.Boolean? ArePageLibraryItems
        // GraphQL -> arePageLibraryItems: Boolean! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("arePageLibraryItems")]
        public System.Boolean? ArePageLibraryItems { get; set; }

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

    } // class SharePointItems
    #endregion

} // namespace Rubrik.SecurityCloud.Types