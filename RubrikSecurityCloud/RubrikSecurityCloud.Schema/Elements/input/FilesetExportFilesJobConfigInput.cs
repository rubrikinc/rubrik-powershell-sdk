// FilesetExportFilesJobConfigInput.cs
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
    #region FilesetExportFilesJobConfigInput

    public class FilesetExportFilesJobConfigInput: IInput
    {
        #region members

        //      C# -> System.String? HostId
        // GraphQL -> hostId: String (scalar)
        [JsonProperty("hostId")]
        public System.String? HostId { get; set; }

        //      C# -> System.Boolean? IgnoreErrors
        // GraphQL -> ignoreErrors: Boolean (scalar)
        [JsonProperty("ignoreErrors")]
        public System.Boolean? IgnoreErrors { get; set; }

        //      C# -> System.String? ShareId
        // GraphQL -> shareId: String (scalar)
        [JsonProperty("shareId")]
        public System.String? ShareId { get; set; }

        //      C# -> List<System.String>? ExcludePaths
        // GraphQL -> excludePaths: [String!] (scalar)
        [JsonProperty("excludePaths")]
        public List<System.String>? ExcludePaths { get; set; }

        //      C# -> System.Boolean? ShouldRecreateDirectoryStructure
        // GraphQL -> shouldRecreateDirectoryStructure: Boolean (scalar)
        [JsonProperty("shouldRecreateDirectoryStructure")]
        public System.Boolean? ShouldRecreateDirectoryStructure { get; set; }

        //      C# -> System.String? PostRestoreScript
        // GraphQL -> postRestoreScript: String (scalar)
        [JsonProperty("postRestoreScript")]
        public System.String? PostRestoreScript { get; set; }

        //      C# -> System.Boolean? ShouldRestoreOnlyAcls
        // GraphQL -> shouldRestoreOnlyAcls: Boolean (scalar)
        [JsonProperty("shouldRestoreOnlyAcls")]
        public System.Boolean? ShouldRestoreOnlyAcls { get; set; }

        //      C# -> List<FilesetExportPathPairInput>? ExportPathPairs
        // GraphQL -> exportPathPairs: [FilesetExportPathPairInput!]! (input)
        [Required]
        [JsonRequired]
        [JsonProperty("exportPathPairs")]
        public List<FilesetExportPathPairInput>? ExportPathPairs { get; set; }


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

    } // class FilesetExportFilesJobConfigInput
    #endregion

} // namespace RubrikSecurityCloud.Types