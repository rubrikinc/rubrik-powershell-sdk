// ForestRecoveryGlobalConfig.cs
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
    #region ForestRecoveryGlobalConfig

    public class ForestRecoveryGlobalConfig: IInput
    {
        #region members

        //      C# -> System.String? ForestId
        // GraphQL -> forestId: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("forestId")]
        public System.String? ForestId { get; set; }

        //      C# -> DnsRecoveryType? DnsRecoveryType
        // GraphQL -> dnsRecoveryType: DnsRecoveryType (enum)
        [JsonProperty("dnsRecoveryType")]
        public DnsRecoveryType? DnsRecoveryType { get; set; }

        //      C# -> List<System.String>? CustomDnsIps
        // GraphQL -> customDnsIps: [String!] (scalar)
        [JsonProperty("customDnsIps")]
        public List<System.String>? CustomDnsIps { get; set; }

        //      C# -> System.Boolean? ShouldRebuildGc
        // GraphQL -> shouldRebuildGc: Boolean (scalar)
        [JsonProperty("shouldRebuildGc")]
        public System.Boolean? ShouldRebuildGc { get; set; }

        //      C# -> System.Boolean? ShouldResetKerberos
        // GraphQL -> shouldResetKerberos: Boolean (scalar)
        [JsonProperty("shouldResetKerberos")]
        public System.Boolean? ShouldResetKerberos { get; set; }

        //      C# -> List<System.String>? WinTimeServers
        // GraphQL -> winTimeServers: [String!] (scalar)
        [JsonProperty("winTimeServers")]
        public List<System.String>? WinTimeServers { get; set; }


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

    } // class ForestRecoveryGlobalConfig
    #endregion

} // namespace RubrikSecurityCloud.Types