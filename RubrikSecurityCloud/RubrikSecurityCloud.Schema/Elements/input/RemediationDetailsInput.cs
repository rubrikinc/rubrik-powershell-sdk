// RemediationDetailsInput.cs
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
    #region RemediationDetailsInput

    public class RemediationDetailsInput: IInput
    {
        #region members

        //      C# -> RemediationTicketInfoInput? TicketInfo
        // GraphQL -> ticketInfo: RemediationTicketInfoInput (input)
        [JsonProperty("ticketInfo")]
        public RemediationTicketInfoInput? TicketInfo { get; set; }

        //      C# -> MipLabelInfoInput? MipLabelInfo
        // GraphQL -> mipLabelInfo: MipLabelInfoInput (input)
        [JsonProperty("mipLabelInfo")]
        public MipLabelInfoInput? MipLabelInfo { get; set; }

        //      C# -> AdIrInfoInput? AdIrInfo
        // GraphQL -> adIrInfo: AdIrInfoInput (input)
        [JsonProperty("adIrInfo")]
        public AdIrInfoInput? AdIrInfo { get; set; }

        //      C# -> TicketDetailsInput? TicketDetails
        // GraphQL -> ticketDetails: TicketDetailsInput (input)
        [JsonProperty("ticketDetails")]
        public TicketDetailsInput? TicketDetails { get; set; }


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

    } // class RemediationDetailsInput
    #endregion

} // namespace RubrikSecurityCloud.Types