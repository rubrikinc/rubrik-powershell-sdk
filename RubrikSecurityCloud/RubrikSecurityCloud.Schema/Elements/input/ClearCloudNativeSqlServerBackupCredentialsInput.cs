// ClearCloudNativeSqlServerBackupCredentialsInput.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:04:16.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Rubrik.SecurityCloud.Types
{
    #region ClearCloudNativeSqlServerBackupCredentialsInput

    public class ClearCloudNativeSqlServerBackupCredentialsInput
    {
        #region members
        //      C# -> List<System.String>? ObjectIds
        // GraphQL -> objectIds: [UUID!]! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("objectIds")]
        public List<System.String>? ObjectIds { get; set; }

        //      C# -> WorkloadLevelHierarchy? WorkloadType
        // GraphQL -> workloadType: WorkloadLevelHierarchy! (enum)
        [Required]
        [JsonRequired]
        [JsonProperty("workloadType")]
        public WorkloadLevelHierarchy? WorkloadType { get; set; }

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

    } // class ClearCloudNativeSqlServerBackupCredentialsInput
    #endregion

} // namespace Rubrik.SecurityCloud.Types