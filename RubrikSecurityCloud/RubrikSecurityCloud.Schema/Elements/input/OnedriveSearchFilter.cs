// OnedriveSearchFilter.cs
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
    #region OnedriveSearchFilter

    public class OnedriveSearchFilter: IInput
    {
        #region members

        //      C# -> OnedriveSearchKeywordFilter? SearchKeywordFilter
        // GraphQL -> searchKeywordFilter: OnedriveSearchKeywordFilter (input)
        [JsonProperty("searchKeywordFilter")]
        public OnedriveSearchKeywordFilter? SearchKeywordFilter { get; set; }

        //      C# -> TimeRangeFilter? ModifiedTime
        // GraphQL -> modifiedTime: TimeRangeFilter (input)
        [JsonProperty("modifiedTime")]
        public TimeRangeFilter? ModifiedTime { get; set; }

        //      C# -> TimeRangeFilter? CreateTime
        // GraphQL -> createTime: TimeRangeFilter (input)
        [JsonProperty("createTime")]
        public TimeRangeFilter? CreateTime { get; set; }

        //      C# -> OnedriveSearchObjectFilter? SearchObjectFilter
        // GraphQL -> searchObjectFilter: OnedriveSearchObjectFilter (input)
        [JsonProperty("searchObjectFilter")]
        public OnedriveSearchObjectFilter? SearchObjectFilter { get; set; }

        //      C# -> System.String? ChannelId
        // GraphQL -> channelId: String (scalar)
        [JsonProperty("channelId")]
        public System.String? ChannelId { get; set; }

        //      C# -> System.String? ChannelFolderName
        // GraphQL -> channelFolderName: String (scalar)
        [JsonProperty("channelFolderName")]
        public System.String? ChannelFolderName { get; set; }

        //      C# -> ChannelMembershipType? ChannelMembershipType
        // GraphQL -> channelMembershipType: ChannelMembershipType (enum)
        [JsonProperty("channelMembershipType")]
        public ChannelMembershipType? ChannelMembershipType { get; set; }

        //      C# -> System.Boolean? ExcludeItemsUnderRoot
        // GraphQL -> excludeItemsUnderRoot: Boolean (scalar)
        [JsonProperty("excludeItemsUnderRoot")]
        public System.Boolean? ExcludeItemsUnderRoot { get; set; }

        //      C# -> System.String? ChannelNameKeyword
        // GraphQL -> channelNameKeyword: String (scalar)
        [JsonProperty("channelNameKeyword")]
        public System.String? ChannelNameKeyword { get; set; }

        //      C# -> System.Boolean? UseExactVersionMatch
        // GraphQL -> useExactVersionMatch: Boolean (scalar)
        [JsonProperty("useExactVersionMatch")]
        public System.Boolean? UseExactVersionMatch { get; set; }

        //      C# -> LambdaPathFilters? LambdaFilters
        // GraphQL -> lambdaFilters: LambdaPathFilters (input)
        [JsonProperty("lambdaFilters")]
        public LambdaPathFilters? LambdaFilters { get; set; }


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

    } // class OnedriveSearchFilter
    #endregion

} // namespace Rubrik.SecurityCloud.Types