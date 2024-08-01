// CreateUserAccessInsightTicketInput.cs
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
    #region CreateUserAccessInsightTicketInput

    public class CreateUserAccessInsightTicketInput: IInput
    {
        #region members

        //      C# -> System.String? InsightUuid
        // GraphQL -> insightUuid: UUID! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("insightUuid")]
        public System.String? InsightUuid { get; set; }

        //      C# -> TicketingPlatform? PlatformType
        // GraphQL -> platformType: TicketingPlatform! (enum)
        [Required]
        [JsonRequired]
        [JsonProperty("platformType")]
        public TicketingPlatform? PlatformType { get; set; }

        //      C# -> TicketInfoInput? TicketInfo
        // GraphQL -> ticketInfo: TicketInfoInput! (input)
        [Required]
        [JsonRequired]
        [JsonProperty("ticketInfo")]
        public TicketInfoInput? TicketInfo { get; set; }

        //      C# -> System.Int64? TimelineDate
        // GraphQL -> timelineDate: Long! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("timelineDate")]
        public System.Int64? TimelineDate { get; set; }


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

    } // class CreateUserAccessInsightTicketInput
    #endregion

} // namespace RubrikSecurityCloud.Types