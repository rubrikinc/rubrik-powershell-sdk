// FilesetCreateInput.cs
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
    #region FilesetCreateInput

    public class FilesetCreateInput: IInput
    {
        #region members

        //      C# -> FilesetArraySpecInput? ArraySpec
        // GraphQL -> arraySpec: FilesetArraySpecInput (input)
        [JsonProperty("arraySpec")]
        public FilesetArraySpecInput? ArraySpec { get; set; }

        //      C# -> System.String? HostId
        // GraphQL -> hostId: String (scalar)
        [JsonProperty("hostId")]
        public System.String? HostId { get; set; }

        //      C# -> System.Boolean? IsPassthrough
        // GraphQL -> isPassthrough: Boolean (scalar)
        [JsonProperty("isPassthrough")]
        public System.Boolean? IsPassthrough { get; set; }

        //      C# -> System.String? ShareId
        // GraphQL -> shareId: String (scalar)
        [JsonProperty("shareId")]
        public System.String? ShareId { get; set; }

        //      C# -> System.Boolean? EnableHardlinkSupport
        // GraphQL -> enableHardlinkSupport: Boolean (scalar)
        [JsonProperty("enableHardlinkSupport")]
        public System.Boolean? EnableHardlinkSupport { get; set; }

        //      C# -> System.Boolean? EnableSymlinkResolution
        // GraphQL -> enableSymlinkResolution: Boolean (scalar)
        [JsonProperty("enableSymlinkResolution")]
        public System.Boolean? EnableSymlinkResolution { get; set; }

        //      C# -> System.String? FailoverClusterAppId
        // GraphQL -> failoverClusterAppId: String (scalar)
        [JsonProperty("failoverClusterAppId")]
        public System.String? FailoverClusterAppId { get; set; }

        //      C# -> System.String? SnapMirrorLabelForFullBackup
        // GraphQL -> snapMirrorLabelForFullBackup: String (scalar)
        [JsonProperty("snapMirrorLabelForFullBackup")]
        public System.String? SnapMirrorLabelForFullBackup { get; set; }

        //      C# -> System.String? SnapMirrorLabelForIncrementalBackup
        // GraphQL -> snapMirrorLabelForIncrementalBackup: String (scalar)
        [JsonProperty("snapMirrorLabelForIncrementalBackup")]
        public System.String? SnapMirrorLabelForIncrementalBackup { get; set; }

        //      C# -> System.Boolean? IsManagedByPolaris
        // GraphQL -> isManagedByPolaris: Boolean (scalar)
        [JsonProperty("isManagedByPolaris")]
        public System.Boolean? IsManagedByPolaris { get; set; }

        //      C# -> System.Boolean? IsPolarisNasModel
        // GraphQL -> isPolarisNasModel: Boolean (scalar)
        [JsonProperty("isPolarisNasModel")]
        public System.Boolean? IsPolarisNasModel { get; set; }

        //      C# -> System.String? TemplateId
        // GraphQL -> templateId: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("templateId")]
        public System.String? TemplateId { get; set; }


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

    } // class FilesetCreateInput
    #endregion

} // namespace Rubrik.SecurityCloud.Types