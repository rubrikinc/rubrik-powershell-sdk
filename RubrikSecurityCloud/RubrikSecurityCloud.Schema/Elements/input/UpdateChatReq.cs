// UpdateChatReq.cs
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
    #region UpdateChatReq

    public class UpdateChatReq: IInput
    {
        #region members

        //      C# -> System.String? ChatId
        // GraphQL -> chatId: UUID! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("chatId")]
        public System.String? ChatId { get; set; }

        //      C# -> System.Boolean? IsPinned
        // GraphQL -> isPinned: Boolean (scalar)
        [JsonProperty("isPinned")]
        public System.Boolean? IsPinned { get; set; }

        //      C# -> System.Boolean? IsArchived
        // GraphQL -> isArchived: Boolean (scalar)
        [JsonProperty("isArchived")]
        public System.Boolean? IsArchived { get; set; }

        //      C# -> System.String? Title
        // GraphQL -> title: String (scalar)
        [JsonProperty("title")]
        public System.String? Title { get; set; }


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

    } // class UpdateChatReq
    #endregion

} // namespace RubrikSecurityCloud.Types