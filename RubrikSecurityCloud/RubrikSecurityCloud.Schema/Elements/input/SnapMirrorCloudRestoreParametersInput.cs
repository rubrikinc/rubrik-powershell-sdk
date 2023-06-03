// SnapMirrorCloudRestoreParametersInput.cs
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
    #region SnapMirrorCloudRestoreParametersInput

    public class SnapMirrorCloudRestoreParametersInput: IInput
    {
        #region members

        //      C# -> System.Boolean? IgnoreErrors
        // GraphQL -> ignoreErrors: Boolean (scalar)
        [JsonProperty("ignoreErrors")]
        public System.Boolean? IgnoreErrors { get; set; }

        //      C# -> System.String? NetAppAggregateName
        // GraphQL -> netAppAggregateName: String (scalar)
        [JsonProperty("netAppAggregateName")]
        public System.String? NetAppAggregateName { get; set; }

        //      C# -> List<SnapMirrorCloudRestorePathPairInput>? RestorePathPairs
        // GraphQL -> restorePathPairs: [SnapMirrorCloudRestorePathPairInput!] (input)
        [JsonProperty("restorePathPairs")]
        public List<SnapMirrorCloudRestorePathPairInput>? RestorePathPairs { get; set; }

        //      C# -> System.String? TargetNasNamespaceId
        // GraphQL -> targetNasNamespaceId: String (scalar)
        [JsonProperty("targetNasNamespaceId")]
        public System.String? TargetNasNamespaceId { get; set; }

        //      C# -> System.String? TargetNasSystemId
        // GraphQL -> targetNasSystemId: String (scalar)
        [JsonProperty("targetNasSystemId")]
        public System.String? TargetNasSystemId { get; set; }

        //      C# -> System.String? TargetNasVolumeId
        // GraphQL -> targetNasVolumeId: String (scalar)
        [JsonProperty("targetNasVolumeId")]
        public System.String? TargetNasVolumeId { get; set; }

        //      C# -> System.String? TargetNasVolumeName
        // GraphQL -> targetNasVolumeName: String (scalar)
        [JsonProperty("targetNasVolumeName")]
        public System.String? TargetNasVolumeName { get; set; }

        //      C# -> System.Boolean? IsVolumeRestore
        // GraphQL -> isVolumeRestore: Boolean! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("isVolumeRestore")]
        public System.Boolean? IsVolumeRestore { get; set; }


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

    } // class SnapMirrorCloudRestoreParametersInput
    #endregion

} // namespace Rubrik.SecurityCloud.Types