// OracleUpdateInput.cs
//
// This generated file is part of the Rubrik PowerShell SDK.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using RubrikSecurityCloud.Schema.Utils;

namespace Rubrik.SecurityCloud.Types
{
    #region OracleUpdateInput

    public class OracleUpdateInput: IInput
    {
        #region members

        //      C# -> System.String? ConfiguredSlaDomainId
        // GraphQL -> configuredSlaDomainId: String (scalar)
        [JsonProperty("configuredSlaDomainId")]
        public System.String? ConfiguredSlaDomainId { get; set; }

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

        //      C# -> System.Int32? HostLogRetentionHours
        // GraphQL -> hostLogRetentionHours: Int (scalar)
        [JsonProperty("hostLogRetentionHours")]
        public System.Int32? HostLogRetentionHours { get; set; }

        //      C# -> System.String? ConfiguredSlaDomainIdDeprecated
        // GraphQL -> configuredSlaDomainIdDeprecated: String (scalar)
        [JsonProperty("configuredSlaDomainIdDeprecated")]
        public System.String? ConfiguredSlaDomainIdDeprecated { get; set; }

        //      C# -> List<OracleNodeOrderInput>? NodeOrder
        // GraphQL -> nodeOrder: [OracleNodeOrderInput!] (input)
        [JsonProperty("nodeOrder")]
        public List<OracleNodeOrderInput>? NodeOrder { get; set; }

        //      C# -> System.Boolean? ShouldDistributeBackupsAutomatically
        // GraphQL -> shouldDistributeBackupsAutomatically: Boolean (scalar)
        [JsonProperty("shouldDistributeBackupsAutomatically")]
        public System.Boolean? ShouldDistributeBackupsAutomatically { get; set; }

        //      C# -> OracleUpdateCommonInput? OracleUpdateCommon
        // GraphQL -> oracleUpdateCommon: OracleUpdateCommonInput (input)
        [JsonProperty("oracleUpdateCommon")]
        public OracleUpdateCommonInput? OracleUpdateCommon { get; set; }


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

    } // class OracleUpdateInput
    #endregion

} // namespace Rubrik.SecurityCloud.Types