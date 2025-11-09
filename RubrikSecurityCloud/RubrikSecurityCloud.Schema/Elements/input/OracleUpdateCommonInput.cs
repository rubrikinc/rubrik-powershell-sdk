// OracleUpdateCommonInput.cs
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
    #region OracleUpdateCommonInput

    public class OracleUpdateCommonInput: IInput
    {
        #region members

        //      C# -> System.Int32? HostLogRetentionHours
        // GraphQL -> hostLogRetentionHours: Int (scalar)
        [JsonProperty("hostLogRetentionHours")]
        public System.Int32? HostLogRetentionHours { get; set; }

        //      C# -> System.String? HostMount
        // GraphQL -> hostMount: String (scalar)
        [JsonProperty("hostMount")]
        public System.String? HostMount { get; set; }

        //      C# -> System.Int32? LogBackupFrequencyInMinutes
        // GraphQL -> logBackupFrequencyInMinutes: Int (scalar)
        [JsonProperty("logBackupFrequencyInMinutes")]
        public System.Int32? LogBackupFrequencyInMinutes { get; set; }

        //      C# -> System.Int32? LogRetentionHours
        // GraphQL -> logRetentionHours: Int (scalar)
        [JsonProperty("logRetentionHours")]
        public System.Int32? LogRetentionHours { get; set; }

        //      C# -> System.Int32? NumChannels
        // GraphQL -> numChannels: Int (scalar)
        [JsonProperty("numChannels")]
        public System.Int32? NumChannels { get; set; }

        //      C# -> System.Boolean? HasLogConfigFromSla
        // GraphQL -> hasLogConfigFromSla: Boolean (scalar)
        [JsonProperty("hasLogConfigFromSla")]
        public System.Boolean? HasLogConfigFromSla { get; set; }

        //      C# -> System.Boolean? ShouldEnableHighFileCountSupport
        // GraphQL -> shouldEnableHighFileCountSupport: Boolean (scalar)
        [JsonProperty("shouldEnableHighFileCountSupport")]
        public System.Boolean? ShouldEnableHighFileCountSupport { get; set; }

        //      C# -> System.Boolean? ShouldUseSecureThriftForDataTransfer
        // GraphQL -> shouldUseSecureThriftForDataTransfer: Boolean (scalar)
        [JsonProperty("shouldUseSecureThriftForDataTransfer")]
        public System.Boolean? ShouldUseSecureThriftForDataTransfer { get; set; }

        //      C# -> System.Int32? SectionSizeInGb
        // GraphQL -> sectionSizeInGb: Int (scalar)
        [JsonProperty("sectionSizeInGb")]
        public System.Int32? SectionSizeInGb { get; set; }

        //      C# -> System.Int32? RatePerRmanChannelInMb
        // GraphQL -> ratePerRmanChannelInMb: Int (scalar)
        [JsonProperty("ratePerRmanChannelInMb")]
        public System.Int32? RatePerRmanChannelInMb { get; set; }

        //      C# -> System.Boolean? IsPaused
        // GraphQL -> isPaused: Boolean (scalar)
        [JsonProperty("isPaused")]
        public System.Boolean? IsPaused { get; set; }


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

    } // class OracleUpdateCommonInput
    #endregion

} // namespace RubrikSecurityCloud.Types