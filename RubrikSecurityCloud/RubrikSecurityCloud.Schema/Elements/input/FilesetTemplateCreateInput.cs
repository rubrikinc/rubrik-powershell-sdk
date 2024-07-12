// FilesetTemplateCreateInput.cs
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
    #region FilesetTemplateCreateInput

    public class FilesetTemplateCreateInput: IInput
    {
        #region members

        //      C# -> System.String? BackupScriptErrorHandling
        // GraphQL -> backupScriptErrorHandling: String (scalar)
        [JsonProperty("backupScriptErrorHandling")]
        public System.String? BackupScriptErrorHandling { get; set; }

        //      C# -> System.Int64? BackupScriptTimeout
        // GraphQL -> backupScriptTimeout: Long (scalar)
        [JsonProperty("backupScriptTimeout")]
        public System.Int64? BackupScriptTimeout { get; set; }

        //      C# -> List<System.String>? Exceptions
        // GraphQL -> exceptions: [String!] (scalar)
        [JsonProperty("exceptions")]
        public List<System.String>? Exceptions { get; set; }

        //      C# -> List<System.String>? Excludes
        // GraphQL -> excludes: [String!] (scalar)
        [JsonProperty("excludes")]
        public List<System.String>? Excludes { get; set; }

        //      C# -> System.Boolean? IsArrayEnabled
        // GraphQL -> isArrayEnabled: Boolean (scalar)
        [JsonProperty("isArrayEnabled")]
        public System.Boolean? IsArrayEnabled { get; set; }

        //      C# -> System.String? PostBackupScript
        // GraphQL -> postBackupScript: String (scalar)
        [JsonProperty("postBackupScript")]
        public System.String? PostBackupScript { get; set; }

        //      C# -> System.String? PreBackupScript
        // GraphQL -> preBackupScript: String (scalar)
        [JsonProperty("preBackupScript")]
        public System.String? PreBackupScript { get; set; }

        //      C# -> System.Boolean? IsCreatedByKupr
        // GraphQL -> isCreatedByKupr: Boolean (scalar)
        [JsonProperty("isCreatedByKupr")]
        public System.Boolean? IsCreatedByKupr { get; set; }

        //      C# -> System.Boolean? IsCreatedByPolarisNas
        // GraphQL -> isCreatedByPolarisNas: Boolean (scalar)
        [JsonProperty("isCreatedByPolarisNas")]
        public System.Boolean? IsCreatedByPolarisNas { get; set; }

        //      C# -> FilesetTemplateCreateOperatingSystemType? OperatingSystemType
        // GraphQL -> operatingSystemType: FilesetTemplateCreateOperatingSystemType (enum)
        [JsonProperty("operatingSystemType")]
        public FilesetTemplateCreateOperatingSystemType? OperatingSystemType { get; set; }

        //      C# -> FilesetTemplateCreateShareType? ShareType
        // GraphQL -> shareType: FilesetTemplateCreateShareType (enum)
        [JsonProperty("shareType")]
        public FilesetTemplateCreateShareType? ShareType { get; set; }

        //      C# -> FilesetOptionsInput? FilesetOptions
        // GraphQL -> filesetOptions: FilesetOptionsInput (input)
        [JsonProperty("filesetOptions")]
        public FilesetOptionsInput? FilesetOptions { get; set; }

        //      C# -> List<System.String>? Includes
        // GraphQL -> includes: [String!]! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("includes")]
        public List<System.String>? Includes { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("name")]
        public System.String? Name { get; set; }


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

    } // class FilesetTemplateCreateInput
    #endregion

} // namespace RubrikSecurityCloud.Types