// TeamsConvChannelInfo.cs
//
// This generated file is part of the Rubrik PowerShell SDK.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Rubrik.SecurityCloud.Types
{
    #region TeamsConvChannelInfo

    public class TeamsConvChannelInfo: IInput
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

        //      C# -> System.String? ChannelFolderId
        // GraphQL -> ChannelFolderId: String (scalar)
        [JsonProperty("ChannelFolderId")]
        public System.String? ChannelFolderId { get; set; }

        //      C# -> System.String? ChannelNaturalId
        // GraphQL -> ChannelNaturalId: String (scalar)
        [JsonProperty("ChannelNaturalId")]
        public System.String? ChannelNaturalId { get; set; }


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

    } // class TeamsConvChannelInfo
    #endregion

} // namespace Rubrik.SecurityCloud.Types