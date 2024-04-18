// UpdateEventDigestInput.cs
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
    #region UpdateEventDigestInput

    public class UpdateEventDigestInput: IInput
    {
        #region members

        //      C# -> System.Int32? DigestId
        // GraphQL -> digestId: Int (scalar)
        [JsonProperty("digestId")]
        public System.Int32? DigestId { get; set; }

        //      C# -> System.String? DigestName
        // GraphQL -> digestName: String (scalar)
        [JsonProperty("digestName")]
        public System.String? DigestName { get; set; }

        //      C# -> System.Int32? FrequencyHours
        // GraphQL -> frequencyHours: Int (scalar)
        [JsonProperty("frequencyHours")]
        public System.Int32? FrequencyHours { get; set; }

        //      C# -> System.Boolean? IsImmediate
        // GraphQL -> isImmediate: Boolean (scalar)
        [JsonProperty("isImmediate")]
        public System.Boolean? IsImmediate { get; set; }

        //      C# -> System.Boolean? IncludeAudits
        // GraphQL -> includeAudits: Boolean (scalar)
        [JsonProperty("includeAudits")]
        public System.Boolean? IncludeAudits { get; set; }

        //      C# -> System.Boolean? IncludeEvents
        // GraphQL -> includeEvents: Boolean (scalar)
        [JsonProperty("includeEvents")]
        public System.Boolean? IncludeEvents { get; set; }

        //      C# -> EventDigestConfig? EventDigestConfig
        // GraphQL -> eventDigestConfig: EventDigestConfig! (input)
        [Required]
        [JsonRequired]
        [JsonProperty("eventDigestConfig")]
        public EventDigestConfig? EventDigestConfig { get; set; }

        //      C# -> List<System.String>? RecipientUserIds
        // GraphQL -> recipientUserIds: [String!]! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("recipientUserIds")]
        public List<System.String>? RecipientUserIds { get; set; }

        //      C# -> List<System.String>? ClusterUuids
        // GraphQL -> clusterUuids: [UUID!] (scalar)
        [JsonProperty("clusterUuids")]
        public List<System.String>? ClusterUuids { get; set; }


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

    } // class UpdateEventDigestInput
    #endregion

} // namespace RubrikSecurityCloud.Types