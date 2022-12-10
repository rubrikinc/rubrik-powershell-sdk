// TeamsChannelInfo.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:04:32.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Rubrik.SecurityCloud.Types
{
    #region TeamsChannelInfo

    public class TeamsChannelInfo
    {
        #region members
        //      C# -> System.String? TeamId
        // GraphQL -> TeamID: UUID! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("TeamID")]
        public System.String? TeamId { get; set; }

        //      C# -> System.String? ChannelId
        // GraphQL -> ChannelID: UUID (scalar)
        [JsonProperty("ChannelID")]
        public System.String? ChannelId { get; set; }

        //      C# -> System.String? ChannelName
        // GraphQL -> ChannelName: String (scalar)
        [JsonProperty("ChannelName")]
        public System.String? ChannelName { get; set; }

        //      C# -> System.String? ChannelFolderName
        // GraphQL -> ChannelFolderName: String (scalar)
        [JsonProperty("ChannelFolderName")]
        public System.String? ChannelFolderName { get; set; }

        //      C# -> System.String? ChannelNaturalId
        // GraphQL -> ChannelNaturalId: String (scalar)
        [JsonProperty("ChannelNaturalId")]
        public System.String? ChannelNaturalId { get; set; }

        //      C# -> ChannelMembershipType? ChannelMembershipType
        // GraphQL -> channelMembershipType: ChannelMembershipType! (enum)
        [Required]
        [JsonRequired]
        [JsonProperty("channelMembershipType")]
        public ChannelMembershipType? ChannelMembershipType { get; set; }

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

    } // class TeamsChannelInfo
    #endregion

} // namespace Rubrik.SecurityCloud.Types