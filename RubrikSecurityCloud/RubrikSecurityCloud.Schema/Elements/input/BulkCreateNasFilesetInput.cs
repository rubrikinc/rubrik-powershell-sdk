// BulkCreateNasFilesetInput.cs
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
    #region BulkCreateNasFilesetInput

    public class BulkCreateNasFilesetInput: IInput
    {
        #region members

        //      C# -> FilesetTemplateCreateInput? FilesetTemplate
        // GraphQL -> filesetTemplate: FilesetTemplateCreateInput! (input)
        [Required]
        [JsonRequired]
        [JsonProperty("filesetTemplate")]
        public FilesetTemplateCreateInput? FilesetTemplate { get; set; }

        //      C# -> System.Boolean? IsHardlinkSupportEnabled
        // GraphQL -> isHardlinkSupportEnabled: Boolean (scalar)
        [JsonProperty("isHardlinkSupportEnabled")]
        public System.Boolean? IsHardlinkSupportEnabled { get; set; }

        //      C# -> System.Boolean? IsPassthrough
        // GraphQL -> isPassthrough: Boolean (scalar)
        [JsonProperty("isPassthrough")]
        public System.Boolean? IsPassthrough { get; set; }

        //      C# -> List<System.String>? NasShareIds
        // GraphQL -> nasShareIds: [String!]! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("nasShareIds")]
        public List<System.String>? NasShareIds { get; set; }

        //      C# -> System.String? SnapMirrorLabelForFullBackup
        // GraphQL -> snapMirrorLabelForFullBackup: String (scalar)
        [JsonProperty("snapMirrorLabelForFullBackup")]
        public System.String? SnapMirrorLabelForFullBackup { get; set; }

        //      C# -> System.String? SnapMirrorLabelForIncrementalBackup
        // GraphQL -> snapMirrorLabelForIncrementalBackup: String (scalar)
        [JsonProperty("snapMirrorLabelForIncrementalBackup")]
        public System.String? SnapMirrorLabelForIncrementalBackup { get; set; }


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

    } // class BulkCreateNasFilesetInput
    #endregion

} // namespace RubrikSecurityCloud.Types