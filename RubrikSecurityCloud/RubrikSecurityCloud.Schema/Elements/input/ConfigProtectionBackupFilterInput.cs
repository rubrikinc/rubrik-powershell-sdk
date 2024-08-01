// ConfigProtectionBackupFilterInput.cs
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
    #region ConfigProtectionBackupFilterInput

    public class ConfigProtectionBackupFilterInput: IInput
    {
        #region members

        //      C# -> List<UploadLocationType>? BackupLocationType
        // GraphQL -> backupLocationType: [UploadLocationType!] (enum)
        [JsonProperty("backupLocationType")]
        public List<UploadLocationType>? BackupLocationType { get; set; }

        //      C# -> List<System.String>? ClusterUuid
        // GraphQL -> clusterUuid: [UUID!] (scalar)
        [JsonProperty("clusterUuid")]
        public List<System.String>? ClusterUuid { get; set; }

        //      C# -> List<System.String>? SoftwareVersion
        // GraphQL -> softwareVersion: [String!] (scalar)
        [JsonProperty("softwareVersion")]
        public List<System.String>? SoftwareVersion { get; set; }


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

    } // class ConfigProtectionBackupFilterInput
    #endregion

} // namespace RubrikSecurityCloud.Types