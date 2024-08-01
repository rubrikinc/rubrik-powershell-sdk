// TicketsFilterInput.cs
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
    #region TicketsFilterInput

    public class TicketsFilterInput: IInput
    {
        #region members

        //      C# -> List<System.String>? TicketCreatorEmails
        // GraphQL -> ticketCreatorEmails: [String!] (scalar)
        [JsonProperty("ticketCreatorEmails")]
        public List<System.String>? TicketCreatorEmails { get; set; }

        //      C# -> TicketStatus? TicketStatus
        // GraphQL -> ticketStatus: TicketStatus (enum)
        [JsonProperty("ticketStatus")]
        public TicketStatus? TicketStatus { get; set; }

        //      C# -> DateTime? TicketCreationStartTime
        // GraphQL -> ticketCreationStartTime: DateTime (scalar)
        [JsonProperty("ticketCreationStartTime")]
        public DateTime? TicketCreationStartTime { get; set; }

        //      C# -> DateTime? TicketCreationEndTime
        // GraphQL -> ticketCreationEndTime: DateTime (scalar)
        [JsonProperty("ticketCreationEndTime")]
        public DateTime? TicketCreationEndTime { get; set; }

        //      C# -> System.String? TicketName
        // GraphQL -> ticketName: String (scalar)
        [JsonProperty("ticketName")]
        public System.String? TicketName { get; set; }

        //      C# -> TicketFilingFeatureName? FeatureName
        // GraphQL -> featureName: TicketFilingFeatureName (enum)
        [JsonProperty("featureName")]
        public TicketFilingFeatureName? FeatureName { get; set; }

        //      C# -> System.String? TicketUuid
        // GraphQL -> ticketUuid: String (scalar)
        [JsonProperty("ticketUuid")]
        public System.String? TicketUuid { get; set; }

        //      C# -> TicketingPlatform? PlatformType
        // GraphQL -> platformType: TicketingPlatform (enum)
        [JsonProperty("platformType")]
        public TicketingPlatform? PlatformType { get; set; }


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

    } // class TicketsFilterInput
    #endregion

} // namespace RubrikSecurityCloud.Types