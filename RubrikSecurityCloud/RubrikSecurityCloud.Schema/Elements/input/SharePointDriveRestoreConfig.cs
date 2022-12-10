// SharePointDriveRestoreConfig.cs
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
    #region SharePointDriveRestoreConfig

    public class SharePointDriveRestoreConfig
    {
        #region members
        //      C# -> DriveRestoreConfig? DriveRestoreConfig
        // GraphQL -> driveRestoreConfig: DriveRestoreConfig! (input)
        [Required]
        [JsonRequired]
        [JsonProperty("driveRestoreConfig")]
        public DriveRestoreConfig? DriveRestoreConfig { get; set; }

        //      C# -> System.String? DocLibName
        // GraphQL -> docLibName: String (scalar)
        [JsonProperty("docLibName")]
        public System.String? DocLibName { get; set; }

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

    } // class SharePointDriveRestoreConfig
    #endregion

} // namespace Rubrik.SecurityCloud.Types