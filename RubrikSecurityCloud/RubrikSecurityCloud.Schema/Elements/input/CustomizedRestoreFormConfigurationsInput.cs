// CustomizedRestoreFormConfigurationsInput.cs
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
    #region CustomizedRestoreFormConfigurationsInput

    public class CustomizedRestoreFormConfigurationsInput: IInput
    {
        #region members

        //      C# -> List<CustomizedRestoreFormConfigurationGuestOsInput>? GuestOsCredentials
        // GraphQL -> guestOsCredentials: [CustomizedRestoreFormConfigurationGuestOsInput!] (input)
        [JsonProperty("guestOsCredentials")]
        public List<CustomizedRestoreFormConfigurationGuestOsInput>? GuestOsCredentials { get; set; }

        //      C# -> CustomizedRestoreFormConfigurationKmipClientInput? KmipClient
        // GraphQL -> kmipClient: CustomizedRestoreFormConfigurationKmipClientInput (input)
        [JsonProperty("kmipClient")]
        public CustomizedRestoreFormConfigurationKmipClientInput? KmipClient { get; set; }

        //      C# -> List<RestoreFormConfigurationKmipServerInput>? KmipServers
        // GraphQL -> kmipServers: [RestoreFormConfigurationKmipServerInput!] (input)
        [JsonProperty("kmipServers")]
        public List<RestoreFormConfigurationKmipServerInput>? KmipServers { get; set; }

        //      C# -> List<CustomizedRestoreFormConfigurationLdapServerInput>? LdapServers
        // GraphQL -> ldapServers: [CustomizedRestoreFormConfigurationLdapServerInput!] (input)
        [JsonProperty("ldapServers")]
        public List<CustomizedRestoreFormConfigurationLdapServerInput>? LdapServers { get; set; }

        //      C# -> List<CustomizedRestoreFormConfigurationNasHostInput>? NasHosts
        // GraphQL -> nasHosts: [CustomizedRestoreFormConfigurationNasHostInput!] (input)
        [JsonProperty("nasHosts")]
        public List<CustomizedRestoreFormConfigurationNasHostInput>? NasHosts { get; set; }

        //      C# -> List<CustomizedRestoreFormConfigurationObjectStoreArchivalLocationInput>? ObjectStoreArchivalLocations
        // GraphQL -> objectStoreArchivalLocations: [CustomizedRestoreFormConfigurationObjectStoreArchivalLocationInput!] (input)
        [JsonProperty("objectStoreArchivalLocations")]
        public List<CustomizedRestoreFormConfigurationObjectStoreArchivalLocationInput>? ObjectStoreArchivalLocations { get; set; }

        //      C# -> List<RestoreFormConfigurationOrganizationInput>? Organizations
        // GraphQL -> organizations: [RestoreFormConfigurationOrganizationInput!] (input)
        [JsonProperty("organizations")]
        public List<RestoreFormConfigurationOrganizationInput>? Organizations { get; set; }

        //      C# -> List<CustomizedRestoreFormConfigurationReplicationTargetInput>? ReplicationTargets
        // GraphQL -> replicationTargets: [CustomizedRestoreFormConfigurationReplicationTargetInput!] (input)
        [JsonProperty("replicationTargets")]
        public List<CustomizedRestoreFormConfigurationReplicationTargetInput>? ReplicationTargets { get; set; }

        //      C# -> List<RestoreFormConfigurationReportInput>? Reports
        // GraphQL -> reports: [RestoreFormConfigurationReportInput!] (input)
        [JsonProperty("reports")]
        public List<RestoreFormConfigurationReportInput>? Reports { get; set; }

        //      C# -> List<RestoreFormConfigurationRoleInput>? Roles
        // GraphQL -> roles: [RestoreFormConfigurationRoleInput!] (input)
        [JsonProperty("roles")]
        public List<RestoreFormConfigurationRoleInput>? Roles { get; set; }

        //      C# -> List<CustomizedRestoreFormConfigurationS3ArchivalLocationInput>? S3ArchivalLocations
        // GraphQL -> s3ArchivalLocations: [CustomizedRestoreFormConfigurationS3ArchivalLocationInput!] (input)
        [JsonProperty("s3ArchivalLocations")]
        public List<CustomizedRestoreFormConfigurationS3ArchivalLocationInput>? S3ArchivalLocations { get; set; }

        //      C# -> List<RestoreFormConfigurationSlaDomainInput>? SlaDomains
        // GraphQL -> slaDomains: [RestoreFormConfigurationSlaDomainInput!] (input)
        [JsonProperty("slaDomains")]
        public List<RestoreFormConfigurationSlaDomainInput>? SlaDomains { get; set; }

        //      C# -> List<CustomizedRestoreFormConfigurationSmtpInput>? SmtpSettings
        // GraphQL -> smtpSettings: [CustomizedRestoreFormConfigurationSmtpInput!] (input)
        [JsonProperty("smtpSettings")]
        public List<CustomizedRestoreFormConfigurationSmtpInput>? SmtpSettings { get; set; }

        //      C# -> List<CustomizedRestoreFormConfigurationSnmpInput>? SnmpSettings
        // GraphQL -> snmpSettings: [CustomizedRestoreFormConfigurationSnmpInput!] (input)
        [JsonProperty("snmpSettings")]
        public List<CustomizedRestoreFormConfigurationSnmpInput>? SnmpSettings { get; set; }

        //      C# -> List<CustomizedRestoreFormConfigurationUserInput>? Users
        // GraphQL -> users: [CustomizedRestoreFormConfigurationUserInput!] (input)
        [JsonProperty("users")]
        public List<CustomizedRestoreFormConfigurationUserInput>? Users { get; set; }

        //      C# -> List<CustomizedRestoreFormConfigurationVcenterServerInput>? VcenterServers
        // GraphQL -> vcenterServers: [CustomizedRestoreFormConfigurationVcenterServerInput!] (input)
        [JsonProperty("vcenterServers")]
        public List<CustomizedRestoreFormConfigurationVcenterServerInput>? VcenterServers { get; set; }

        //      C# -> List<RestoreFormConfigurationWinAndUnixHostInput>? WinAndUnixHosts
        // GraphQL -> winAndUnixHosts: [RestoreFormConfigurationWinAndUnixHostInput!] (input)
        [JsonProperty("winAndUnixHosts")]
        public List<RestoreFormConfigurationWinAndUnixHostInput>? WinAndUnixHosts { get; set; }


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

    } // class CustomizedRestoreFormConfigurationsInput
    #endregion

} // namespace Rubrik.SecurityCloud.Types