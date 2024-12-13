// RecoverCloudDirectMultiPathsInput.cs
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
    #region RecoverCloudDirectMultiPathsInput

    public class RecoverCloudDirectMultiPathsInput: IInput
    {
        #region members

        //      C# -> System.String? SnapshotFid
        // GraphQL -> snapshotFid: UUID! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("snapshotFid")]
        public System.String? SnapshotFid { get; set; }

        //      C# -> List<NascdRestorePathPairInput>? RestorePathPairList
        // GraphQL -> restorePathPairList: [NascdRestorePathPairInput!]! (input)
        [Required]
        [JsonRequired]
        [JsonProperty("restorePathPairList")]
        public List<NascdRestorePathPairInput>? RestorePathPairList { get; set; }

        //      C# -> System.Int32? DstExportId
        // GraphQL -> dstExportId: Int (scalar)
        [JsonProperty("dstExportId")]
        public System.Int32? DstExportId { get; set; }

        //      C# -> System.Int32? DstExportFid
        // GraphQL -> dstExportFid: Int (scalar)
        [JsonProperty("dstExportFid")]
        public System.Int32? DstExportFid { get; set; }


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

    } // class RecoverCloudDirectMultiPathsInput
    #endregion

} // namespace RubrikSecurityCloud.Types