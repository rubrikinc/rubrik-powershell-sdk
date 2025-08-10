// FilesetTemplatePatchInput.cs
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
    #region FilesetTemplatePatchInput

    public class FilesetTemplatePatchInput: IInput
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

        //      C# -> List<System.String>? Includes
        // GraphQL -> includes: [String!] (scalar)
        [JsonProperty("includes")]
        public List<System.String>? Includes { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

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

        //      C# -> System.String? TemplateBlocklistedFilesystemPaths
        // GraphQL -> templateBlocklistedFilesystemPaths: String (scalar)
        [JsonProperty("templateBlocklistedFilesystemPaths")]
        public System.String? TemplateBlocklistedFilesystemPaths { get; set; }

        //      C# -> System.Boolean? ShouldRetryPrescriptIfBackupFails
        // GraphQL -> shouldRetryPrescriptIfBackupFails: Boolean (scalar)
        [JsonProperty("shouldRetryPrescriptIfBackupFails")]
        public System.Boolean? ShouldRetryPrescriptIfBackupFails { get; set; }

        //      C# -> System.Boolean? ShouldOverrideClusterWideBlocklistedFilesystemPaths
        // GraphQL -> shouldOverrideClusterWideBlocklistedFilesystemPaths: Boolean (scalar)
        [JsonProperty("shouldOverrideClusterWideBlocklistedFilesystemPaths")]
        public System.Boolean? ShouldOverrideClusterWideBlocklistedFilesystemPaths { get; set; }

        //      C# -> FilesetTemplatePatchOperatingSystemType? OperatingSystemType
        // GraphQL -> operatingSystemType: FilesetTemplatePatchOperatingSystemType (enum)
        [JsonProperty("operatingSystemType")]
        public FilesetTemplatePatchOperatingSystemType? OperatingSystemType { get; set; }

        //      C# -> FilesetTemplatePatchShareType? ShareType
        // GraphQL -> shareType: FilesetTemplatePatchShareType (enum)
        [JsonProperty("shareType")]
        public FilesetTemplatePatchShareType? ShareType { get; set; }

        //      C# -> FilesetOptionsInput? FilesetOptions
        // GraphQL -> filesetOptions: FilesetOptionsInput (input)
        [JsonProperty("filesetOptions")]
        public FilesetOptionsInput? FilesetOptions { get; set; }

        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("id")]
        public System.String? Id { get; set; }


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

    } // class FilesetTemplatePatchInput
    #endregion

} // namespace RubrikSecurityCloud.Types