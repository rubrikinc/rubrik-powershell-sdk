// OperationalRecoverySpec.cs
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
    #region OperationalRecoverySpec

    public class OperationalRecoverySpec: IInput
    {
        #region members

        //      C# -> MailboxOperationalRecoverySpec? MailboxOperationalRecoverySpec
        // GraphQL -> mailboxOperationalRecoverySpec: MailboxOperationalRecoverySpec (input)
        [JsonProperty("mailboxOperationalRecoverySpec")]
        public MailboxOperationalRecoverySpec? MailboxOperationalRecoverySpec { get; set; }

        //      C# -> CalendarOperationalRecoverySpec? CalendarOperationalRecoverySpec
        // GraphQL -> calendarOperationalRecoverySpec: CalendarOperationalRecoverySpec (input)
        [JsonProperty("calendarOperationalRecoverySpec")]
        public CalendarOperationalRecoverySpec? CalendarOperationalRecoverySpec { get; set; }

        //      C# -> OperationalRecoveryStage? OperationalRecoveryStage
        // GraphQL -> operationalRecoveryStage: OperationalRecoveryStage (enum)
        [JsonProperty("operationalRecoveryStage")]
        public OperationalRecoveryStage? OperationalRecoveryStage { get; set; }

        //      C# -> System.Boolean? ShouldAutoComplete
        // GraphQL -> shouldAutoComplete: Boolean (scalar)
        [JsonProperty("shouldAutoComplete")]
        public System.Boolean? ShouldAutoComplete { get; set; }

        //      C# -> SharepointOperationalRecoverySpec? SharepointOperationalRecoverySpec
        // GraphQL -> sharepointOperationalRecoverySpec: SharepointOperationalRecoverySpec (input)
        [JsonProperty("sharepointOperationalRecoverySpec")]
        public SharepointOperationalRecoverySpec? SharepointOperationalRecoverySpec { get; set; }

        //      C# -> OnedriveOperationalRecoverySpec? OnedriveOperationalRecoverySpec
        // GraphQL -> onedriveOperationalRecoverySpec: OnedriveOperationalRecoverySpec (input)
        [JsonProperty("onedriveOperationalRecoverySpec")]
        public OnedriveOperationalRecoverySpec? OnedriveOperationalRecoverySpec { get; set; }

        //      C# -> System.String? LastPhaseRecoveryJobId
        // GraphQL -> lastPhaseRecoveryJobId: UUID (scalar)
        [JsonProperty("lastPhaseRecoveryJobId")]
        public System.String? LastPhaseRecoveryJobId { get; set; }


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

    } // class OperationalRecoverySpec
    #endregion

} // namespace RubrikSecurityCloud.Types