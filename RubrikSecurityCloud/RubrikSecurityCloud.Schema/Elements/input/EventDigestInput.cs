// EventDigestInput.cs
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
    #region EventDigestInput

    public class EventDigestInput: IInput
    {
        #region members

        //      C# -> System.Int32? DigestId
        // GraphQL -> digestId: Int (scalar)
        [JsonProperty("digestId")]
        public System.Int32? DigestId { get; set; }

        //      C# -> System.String? DigestName
        // GraphQL -> digestName: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("digestName")]
        public System.String? DigestName { get; set; }

        //      C# -> System.Int32? FrequencyHours
        // GraphQL -> frequencyHours: Int! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("frequencyHours")]
        public System.Int32? FrequencyHours { get; set; }

        //      C# -> System.Boolean? IsImmediate
        // GraphQL -> isImmediate: Boolean! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("isImmediate")]
        public System.Boolean? IsImmediate { get; set; }

        //      C# -> System.Boolean? IncludeAudits
        // GraphQL -> includeAudits: Boolean! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("includeAudits")]
        public System.Boolean? IncludeAudits { get; set; }

        //      C# -> System.Boolean? IncludeEvents
        // GraphQL -> includeEvents: Boolean! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("includeEvents")]
        public System.Boolean? IncludeEvents { get; set; }

        //      C# -> EventDigestConfig? EventDigestConfig
        // GraphQL -> eventDigestConfig: EventDigestConfig! (input)
        [Required]
        [JsonRequired]
        [JsonProperty("eventDigestConfig")]
        public EventDigestConfig? EventDigestConfig { get; set; }

        //      C# -> System.String? RecipientUserId
        // GraphQL -> recipientUserId: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("recipientUserId")]
        public System.String? RecipientUserId { get; set; }

        //      C# -> List<System.String>? ClusterUuids
        // GraphQL -> clusterUuids: [UUID!]! (scalar)
        [Required]
        [JsonRequired]
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

    } // class EventDigestInput
    #endregion

} // namespace RubrikSecurityCloud.Types