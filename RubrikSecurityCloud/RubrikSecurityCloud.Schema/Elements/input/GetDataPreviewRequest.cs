// GetDataPreviewRequest.cs
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
    #region GetDataPreviewRequest

    public class GetDataPreviewRequest: IInput
    {
        #region members

        //      C# -> System.String? WorkloadFid
        // GraphQL -> workloadFid: String (scalar)
        [JsonProperty("workloadFid")]
        public System.String? WorkloadFid { get; set; }

        //      C# -> System.String? FilePath
        // GraphQL -> filePath: String (scalar)
        [JsonProperty("filePath")]
        public System.String? FilePath { get; set; }

        //      C# -> System.String? SnapshotFid
        // GraphQL -> snapshotFid: String (scalar)
        [JsonProperty("snapshotFid")]
        public System.String? SnapshotFid { get; set; }

        //      C# -> PreviewRequestoneof? PreviewRequest
        // GraphQL -> previewRequest: Preview_requestOneof (input)
        [JsonProperty("previewRequest")]
        public PreviewRequestoneof? PreviewRequest { get; set; }


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

    } // class GetDataPreviewRequest
    #endregion

} // namespace RubrikSecurityCloud.Types