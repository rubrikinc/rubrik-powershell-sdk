// BrowseDirectoryFiltersInput.cs
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
    #region BrowseDirectoryFiltersInput

    public class BrowseDirectoryFiltersInput: IInput
    {
        #region members

        //      C# -> List<System.String>? AnalyzerGroupIds
        // GraphQL -> analyzerGroupIds: [String!] (scalar)
        [JsonProperty("analyzerGroupIds")]
        public List<System.String>? AnalyzerGroupIds { get; set; }

        //      C# -> System.Boolean? WhitelistEnabled
        // GraphQL -> whitelistEnabled: Boolean (scalar)
        [JsonProperty("whitelistEnabled")]
        public System.Boolean? WhitelistEnabled { get; set; }

        //      C# -> List<System.String>? Sids
        // GraphQL -> sids: [String!] (scalar)
        [JsonProperty("sids")]
        public List<System.String>? Sids { get; set; }

        //      C# -> List<RiskLevelType>? RiskLevelTypesFilter
        // GraphQL -> riskLevelTypesFilter: [RiskLevelType!] (enum)
        [JsonProperty("riskLevelTypesFilter")]
        public List<RiskLevelType>? RiskLevelTypesFilter { get; set; }

        //      C# -> List<System.String>? DataTypeIds
        // GraphQL -> dataTypeIds: [String!] (scalar)
        [JsonProperty("dataTypeIds")]
        public List<System.String>? DataTypeIds { get; set; }

        //      C# -> UserTimeRangeInput? LastAccessFilter
        // GraphQL -> lastAccessFilter: UserTimeRangeInput (input)
        [JsonProperty("lastAccessFilter")]
        public UserTimeRangeInput? LastAccessFilter { get; set; }

        //      C# -> UserTimeRangeInput? LastModifiedFilter
        // GraphQL -> lastModifiedFilter: UserTimeRangeInput (input)
        [JsonProperty("lastModifiedFilter")]
        public UserTimeRangeInput? LastModifiedFilter { get; set; }

        //      C# -> UserTimeRangeInput? CreationTimeFilter
        // GraphQL -> creationTimeFilter: UserTimeRangeInput (input)
        [JsonProperty("creationTimeFilter")]
        public UserTimeRangeInput? CreationTimeFilter { get; set; }

        //      C# -> UserTimeRangeInput? LastScanFilter
        // GraphQL -> lastScanFilter: UserTimeRangeInput (input)
        [JsonProperty("lastScanFilter")]
        public UserTimeRangeInput? LastScanFilter { get; set; }

        //      C# -> List<OpenAccessType>? ExposureFilter
        // GraphQL -> exposureFilter: [OpenAccessType!] (enum)
        [JsonProperty("exposureFilter")]
        public List<OpenAccessType>? ExposureFilter { get; set; }

        //      C# -> List<MipLabelsFilterInput>? MipLabelsFilter
        // GraphQL -> mipLabelsFilter: [MipLabelsFilterInput!] (input)
        [JsonProperty("mipLabelsFilter")]
        public List<MipLabelsFilterInput>? MipLabelsFilter { get; set; }

        //      C# -> List<System.String>? DocumentTypesFilter
        // GraphQL -> documentTypesFilter: [UUID!] (scalar)
        [JsonProperty("documentTypesFilter")]
        public List<System.String>? DocumentTypesFilter { get; set; }

        //      C# -> SensitiveDataDiscoveryScope? SensitiveDataDiscoveryScope
        // GraphQL -> sensitiveDataDiscoveryScope: SensitiveDataDiscoveryScope (enum)
        [JsonProperty("sensitiveDataDiscoveryScope")]
        public SensitiveDataDiscoveryScope? SensitiveDataDiscoveryScope { get; set; }


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

    } // class BrowseDirectoryFiltersInput
    #endregion

} // namespace RubrikSecurityCloud.Types