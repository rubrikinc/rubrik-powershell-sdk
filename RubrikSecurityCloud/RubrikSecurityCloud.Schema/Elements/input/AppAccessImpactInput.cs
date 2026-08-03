// AppAccessImpactInput.cs
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
    #region AppAccessImpactInput

    public class AppAccessImpactInput: IInput
    {
        #region members

        //      C# -> System.String? ActivityId
        // GraphQL -> activityId: UUID! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("activityId")]
        public System.String? ActivityId { get; set; }

        //      C# -> IdentityAlertEventType? ActivityType
        // GraphQL -> activityType: IdentityAlertEventType! (enum)
        [Required]
        [JsonRequired]
        [JsonProperty("activityType")]
        public IdentityAlertEventType? ActivityType { get; set; }

        //      C# -> System.String? ActivityTimestamp
        // GraphQL -> activityTimestamp: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("activityTimestamp")]
        public System.String? ActivityTimestamp { get; set; }

        //      C# -> System.String? UserId
        // GraphQL -> userId: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("userId")]
        public System.String? UserId { get; set; }

        //      C# -> System.String? GroupId
        // GraphQL -> groupId: String (scalar)
        [JsonProperty("groupId")]
        public System.String? GroupId { get; set; }

        //      C# -> System.String? AppId
        // GraphQL -> appId: String (scalar)
        [JsonProperty("appId")]
        public System.String? AppId { get; set; }

        //      C# -> System.Int32? Limit
        // GraphQL -> limit: Int (scalar)
        [JsonProperty("limit")]
        public System.Int32? Limit { get; set; }


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

    } // class AppAccessImpactInput
    #endregion

} // namespace RubrikSecurityCloud.Types