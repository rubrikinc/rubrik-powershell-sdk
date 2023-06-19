// RecoverCloudDirectPathInput.cs
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
    #region RecoverCloudDirectPathInput

    public class RecoverCloudDirectPathInput: IInput
    {
        #region members

        //      C# -> System.String? SnapshotFid
        // GraphQL -> snapshotFid: UUID! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("snapshotFid")]
        public System.String? SnapshotFid { get; set; }

        //      C# -> System.String? SrcPath
        // GraphQL -> srcPath: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("srcPath")]
        public System.String? SrcPath { get; set; }

        //      C# -> System.String? DstPath
        // GraphQL -> dstPath: String (scalar)
        [JsonProperty("dstPath")]
        public System.String? DstPath { get; set; }

        //      C# -> System.Int32? DstExportId
        // GraphQL -> dstExportId: Int (scalar)
        [JsonProperty("dstExportId")]
        public System.Int32? DstExportId { get; set; }


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

    } // class RecoverCloudDirectPathInput
    #endregion

} // namespace RubrikSecurityCloud.Types