// ConfigurationTypes.cs
//
// This generated file is part of the Rubrik PowerShell SDK.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace RubrikSecurityCloud.Types
{
    public enum ConfigurationTypes
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "CONFIGURATION_TYPES_ADAPTIVE_BACKUP")]
        CONFIGURATION_TYPES_ADAPTIVE_BACKUP,

        [EnumMember(Value = "CONFIGURATION_TYPES_ARCHIVAL_LOCATIONS")]
        CONFIGURATION_TYPES_ARCHIVAL_LOCATIONS,

        [EnumMember(Value = "CONFIGURATION_TYPES_CLUSTER_SETTINGS")]
        CONFIGURATION_TYPES_CLUSTER_SETTINGS,

        [EnumMember(Value = "CONFIGURATION_TYPES_GUEST_OS_SETTINGS")]
        CONFIGURATION_TYPES_GUEST_OS_SETTINGS,

        [EnumMember(Value = "CONFIGURATION_TYPES_KMIP_SETTINGS")]
        CONFIGURATION_TYPES_KMIP_SETTINGS,

        [EnumMember(Value = "CONFIGURATION_TYPES_LDAP_SERVERS")]
        CONFIGURATION_TYPES_LDAP_SERVERS,

        [EnumMember(Value = "CONFIGURATION_TYPES_MSSQL_DEFAULTS")]
        CONFIGURATION_TYPES_MSSQL_DEFAULTS,

        [EnumMember(Value = "CONFIGURATION_TYPES_NAS_HOSTS")]
        CONFIGURATION_TYPES_NAS_HOSTS,

        [EnumMember(Value = "CONFIGURATION_TYPES_NETWORK_THROTTLING")]
        CONFIGURATION_TYPES_NETWORK_THROTTLING,

        [EnumMember(Value = "CONFIGURATION_TYPES_NOTIFICATION_SETTINGS")]
        CONFIGURATION_TYPES_NOTIFICATION_SETTINGS,

        [EnumMember(Value = "CONFIGURATION_TYPES_ORGANIZATIONS")]
        CONFIGURATION_TYPES_ORGANIZATIONS,

        [EnumMember(Value = "CONFIGURATION_TYPES_REPLICATION_TARGETS")]
        CONFIGURATION_TYPES_REPLICATION_TARGETS,

        [EnumMember(Value = "CONFIGURATION_TYPES_REPORTS")]
        CONFIGURATION_TYPES_REPORTS,

        [EnumMember(Value = "CONFIGURATION_TYPES_ROLES")]
        CONFIGURATION_TYPES_ROLES,

        [EnumMember(Value = "CONFIGURATION_TYPES_SLA_DOMAINS")]
        CONFIGURATION_TYPES_SLA_DOMAINS,

        [EnumMember(Value = "CONFIGURATION_TYPES_SMTP_SETTINGS")]
        CONFIGURATION_TYPES_SMTP_SETTINGS,

        [EnumMember(Value = "CONFIGURATION_TYPES_SNMP_SETTINGS")]
        CONFIGURATION_TYPES_SNMP_SETTINGS,

        [EnumMember(Value = "CONFIGURATION_TYPES_SYSLOG_SETTINGS")]
        CONFIGURATION_TYPES_SYSLOG_SETTINGS,

        [EnumMember(Value = "CONFIGURATION_TYPES_USERS")]
        CONFIGURATION_TYPES_USERS,

        [EnumMember(Value = "CONFIGURATION_TYPES_VCENTER_SERVERS")]
        CONFIGURATION_TYPES_VCENTER_SERVERS,

        [EnumMember(Value = "CONFIGURATION_TYPES_WIN_AND_UNIX_HOSTS")]
        CONFIGURATION_TYPES_WIN_AND_UNIX_HOSTS


    } // enum ConfigurationTypes

} // namespace RubrikSecurityCloud.Types