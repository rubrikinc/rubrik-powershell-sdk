// ListFileResultFiltersInput.cs
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
    #region ListFileResultFiltersInput

    public class ListFileResultFiltersInput: IInput
    {
        #region members

        //      C# -> List<System.String>? AnalyzerGroupIds
        // GraphQL -> analyzerGroupIds: [String!] (scalar)
        [JsonProperty("analyzerGroupIds")]
        public List<System.String>? AnalyzerGroupIds { get; set; }

        //      C# -> List<SnappablePathInput>? SnappablePaths
        // GraphQL -> snappablePaths: [SnappablePathInput!] (input)
        [JsonProperty("snappablePaths")]
        public List<SnappablePathInput>? SnappablePaths { get; set; }

        //      C# -> List<System.String>? SnappableTypes
        // GraphQL -> snappableTypes: [String!] (scalar)
        [JsonProperty("snappableTypes")]
        public List<System.String>? SnappableTypes { get; set; }

        //      C# -> System.String? SearchText
        // GraphQL -> searchText: String (scalar)
        [JsonProperty("searchText")]
        public System.String? SearchText { get; set; }

        //      C# -> System.Boolean? WhitelistEnabled
        // GraphQL -> whitelistEnabled: Boolean (scalar)
        [JsonProperty("whitelistEnabled")]
        public System.Boolean? WhitelistEnabled { get; set; }

        //      C# -> List<System.String>? Sids
        // GraphQL -> sids: [String!] (scalar)
        [JsonProperty("sids")]
        public List<System.String>? Sids { get; set; }

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

    } // class ListFileResultFiltersInput
    #endregion

} // namespace RubrikSecurityCloud.Types