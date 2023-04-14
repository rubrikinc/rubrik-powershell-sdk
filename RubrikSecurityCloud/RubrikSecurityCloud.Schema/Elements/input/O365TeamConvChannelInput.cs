// O365TeamConvChannelInput.cs
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
    #region O365TeamConvChannelInput

    public class O365TeamConvChannelInput: IInput
    {
        #region members

        //      C# -> System.String? NaturalId
        // GraphQL -> naturalId: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("naturalId")]
        public System.String? NaturalId { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> System.String? FolderId
        // GraphQL -> folderId: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("folderId")]
        public System.String? FolderId { get; set; }

        //      C# -> ChannelMembershipType? MembershipType
        // GraphQL -> membershipType: ChannelMembershipType! (enum)
        [Required]
        [JsonRequired]
        [JsonProperty("membershipType")]
        public ChannelMembershipType? MembershipType { get; set; }


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

    } // class O365TeamConvChannelInput
    #endregion

} // namespace Rubrik.SecurityCloud.Types