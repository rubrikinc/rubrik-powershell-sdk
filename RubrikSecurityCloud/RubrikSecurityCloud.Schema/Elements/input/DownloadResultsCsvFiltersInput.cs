// DownloadResultsCsvFiltersInput.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:04:23.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Rubrik.SecurityCloud.Types
{
    #region DownloadResultsCsvFiltersInput

    public class DownloadResultsCsvFiltersInput
    {
        #region members
        //      C# -> List<System.String>? AnalyzerGroupIds
        // GraphQL -> analyzerGroupIds: [String!] (scalar)
        [JsonProperty("analyzerGroupIds")]
        public List<System.String>? AnalyzerGroupIds { get; set; }

        //      C# -> SnappablePathInput? BrowseDirectorySnappablePath
        // GraphQL -> browseDirectorySnappablePath: SnappablePathInput (input)
        [JsonProperty("browseDirectorySnappablePath")]
        public SnappablePathInput? BrowseDirectorySnappablePath { get; set; }

        //      C# -> List<SnappablePathInput>? ListFileResultsSnappablePaths
        // GraphQL -> listFileResultsSnappablePaths: [SnappablePathInput!] (input)
        [JsonProperty("listFileResultsSnappablePaths")]
        public List<SnappablePathInput>? ListFileResultsSnappablePaths { get; set; }

        //      C# -> List<System.String>? ListFileResultsSnappableTypes
        // GraphQL -> listFileResultsSnappableTypes: [String!] (scalar)
        [JsonProperty("listFileResultsSnappableTypes")]
        public List<System.String>? ListFileResultsSnappableTypes { get; set; }

        //      C# -> System.String? ListFileResultsSearchText
        // GraphQL -> listFileResultsSearchText: String (scalar)
        [JsonProperty("listFileResultsSearchText")]
        public System.String? ListFileResultsSearchText { get; set; }

        //      C# -> System.Boolean? WhitelistEnabled
        // GraphQL -> whitelistEnabled: Boolean (scalar)
        [JsonProperty("whitelistEnabled")]
        public System.Boolean? WhitelistEnabled { get; set; }

        //      C# -> FileCountType? FileType
        // GraphQL -> fileType: FileCountType! (enum)
        [Required]
        [JsonRequired]
        [JsonProperty("fileType")]
        public FileCountType? FileType { get; set; }

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

    } // class DownloadResultsCsvFiltersInput
    #endregion

} // namespace Rubrik.SecurityCloud.Types