// SyslogExportRulePartialInput.cs
//
// This generated file is part of the Rubrik PowerShell SDK.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Rubrik.SecurityCloud.Types
{
    #region SyslogExportRulePartialInput

    public class SyslogExportRulePartialInput: IInput
    {
        #region members

        //      C# -> System.Boolean? EnableTls
        // GraphQL -> enableTls: Boolean (scalar)
        [JsonProperty("enableTls")]
        public System.Boolean? EnableTls { get; set; }

        //      C# -> System.String? Hostname
        // GraphQL -> hostname: String (scalar)
        [JsonProperty("hostname")]
        public System.String? Hostname { get; set; }

        //      C# -> System.Int32? Port
        // GraphQL -> port: Int (scalar)
        [JsonProperty("port")]
        public System.Int32? Port { get; set; }

        //      C# -> System.String? CertificateId
        // GraphQL -> certificateId: String (scalar)
        [JsonProperty("certificateId")]
        public System.String? CertificateId { get; set; }

        //      C# -> SyslogFacility? Facility
        // GraphQL -> facility: SyslogFacility (enum)
        [JsonProperty("facility")]
        public SyslogFacility? Facility { get; set; }

        //      C# -> TransportLayerProtocol? Protocol
        // GraphQL -> protocol: TransportLayerProtocol (enum)
        [JsonProperty("protocol")]
        public TransportLayerProtocol? Protocol { get; set; }

        //      C# -> SyslogSeverity? Severity
        // GraphQL -> severity: SyslogSeverity (enum)
        [JsonProperty("severity")]
        public SyslogSeverity? Severity { get; set; }


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

    } // class SyslogExportRulePartialInput
    #endregion

} // namespace Rubrik.SecurityCloud.Types