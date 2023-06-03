// SharePointListRestoreConfig.cs
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
    #region SharePointListRestoreConfig

    public class SharePointListRestoreConfig: IInput
    {
        #region members

        //      C# -> List<SharePointListItem>? ItemsToRestore
        // GraphQL -> itemsToRestore: [SharePointListItem!]! (input)
        [Required]
        [JsonRequired]
        [JsonProperty("itemsToRestore")]
        public List<SharePointListItem>? ItemsToRestore { get; set; }

        //      C# -> List<FolderInfo>? FoldersToRestore
        // GraphQL -> foldersToRestore: [FolderInfo!]! (input)
        [Required]
        [JsonRequired]
        [JsonProperty("foldersToRestore")]
        public List<FolderInfo>? FoldersToRestore { get; set; }

        //      C# -> System.String? RestoreFolderPath
        // GraphQL -> restoreFolderPath: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("restoreFolderPath")]
        public System.String? RestoreFolderPath { get; set; }

        //      C# -> System.String? ListName
        // GraphQL -> listName: String (scalar)
        [JsonProperty("listName")]
        public System.String? ListName { get; set; }

        //      C# -> System.String? ParentSiteUuid
        // GraphQL -> parentSiteUuid: UUID (scalar)
        [JsonProperty("parentSiteUuid")]
        public System.String? ParentSiteUuid { get; set; }


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

    } // class SharePointListRestoreConfig
    #endregion

} // namespace Rubrik.SecurityCloud.Types