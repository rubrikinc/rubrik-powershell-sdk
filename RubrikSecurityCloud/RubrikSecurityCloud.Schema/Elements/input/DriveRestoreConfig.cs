// DriveRestoreConfig.cs
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
    #region DriveRestoreConfig

    public class DriveRestoreConfig: IInput
    {
        #region members

        //      C# -> List<FileInfo>? FilesToRestore
        // GraphQL -> filesToRestore: [FileInfo!]! (input)
        [Required]
        [JsonRequired]
        [JsonProperty("filesToRestore")]
        public List<FileInfo>? FilesToRestore { get; set; }

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

    } // class DriveRestoreConfig
    #endregion

} // namespace RubrikSecurityCloud.Types