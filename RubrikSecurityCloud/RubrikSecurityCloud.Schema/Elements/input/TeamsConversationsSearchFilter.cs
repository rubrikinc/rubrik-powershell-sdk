// TeamsConversationsSearchFilter.cs
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
    #region TeamsConversationsSearchFilter

    public class TeamsConversationsSearchFilter: IInput
    {
        #region members

        //      C# -> TimeRangeFilter? PostedTime
        // GraphQL -> postedTime: TimeRangeFilter (input)
        [JsonProperty("postedTime")]
        public TimeRangeFilter? PostedTime { get; set; }

        //      C# -> System.String? ChannelNaturalId
        // GraphQL -> channelNaturalId: String (scalar)
        [JsonProperty("channelNaturalId")]
        public System.String? ChannelNaturalId { get; set; }

        //      C# -> System.String? PostedBy
        // GraphQL -> postedBy: String (scalar)
        [JsonProperty("postedBy")]
        public System.String? PostedBy { get; set; }

        //      C# -> System.String? SnapshotId
        // GraphQL -> snapshotId: String (scalar)
        [JsonProperty("snapshotId")]
        public System.String? SnapshotId { get; set; }

        //      C# -> System.String? ParentId
        // GraphQL -> parentId: String (scalar)
        [JsonProperty("parentId")]
        public System.String? ParentId { get; set; }

        //      C# -> System.String? ConvId
        // GraphQL -> convId: String (scalar)
        [JsonProperty("convId")]
        public System.String? ConvId { get; set; }

        //      C# -> System.Int32? SnapshotNum
        // GraphQL -> snapshotNum: Int (scalar)
        [JsonProperty("snapshotNum")]
        public System.Int32? SnapshotNum { get; set; }

        //      C# -> System.Boolean? IncludeArchived
        // GraphQL -> includeArchived: Boolean (scalar)
        [JsonProperty("includeArchived")]
        public System.Boolean? IncludeArchived { get; set; }

        //      C# -> System.String? FetchAllPostSenders
        // GraphQL -> fetchAllPostSenders: String (scalar)
        [JsonProperty("fetchAllPostSenders")]
        public System.String? FetchAllPostSenders { get; set; }

        //      C# -> System.Boolean? SkipPostsAttachments
        // GraphQL -> skipPostsAttachments: Boolean (scalar)
        [JsonProperty("skipPostsAttachments")]
        public System.Boolean? SkipPostsAttachments { get; set; }


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

    } // class TeamsConversationsSearchFilter
    #endregion

} // namespace RubrikSecurityCloud.Types