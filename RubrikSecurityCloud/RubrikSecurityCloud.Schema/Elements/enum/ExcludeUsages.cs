// ExcludeUsages.cs
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
    public enum ExcludeUsages
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "EXCLUDE_USAGES_KMIP_CLIENT")]
        EXCLUDE_USAGES_KMIP_CLIENT,

        [EnumMember(Value = "EXCLUDE_USAGES_KMIP_SERVER")]
        EXCLUDE_USAGES_KMIP_SERVER,

        [EnumMember(Value = "EXCLUDE_USAGES_LDAP")]
        EXCLUDE_USAGES_LDAP,

        [EnumMember(Value = "EXCLUDE_USAGES_MONGO_SOURCE")]
        EXCLUDE_USAGES_MONGO_SOURCE,

        [EnumMember(Value = "EXCLUDE_USAGES_MSSQL_SENSITIVE_DATA_DISCOVERY")]
        EXCLUDE_USAGES_MSSQL_SENSITIVE_DATA_DISCOVERY,

        [EnumMember(Value = "EXCLUDE_USAGES_RBS")]
        EXCLUDE_USAGES_RBS,

        [EnumMember(Value = "EXCLUDE_USAGES_RSA")]
        EXCLUDE_USAGES_RSA,

        [EnumMember(Value = "EXCLUDE_USAGES_RUBRIK_CLUSTER_CERTIFICATE_AUTHORITY")]
        EXCLUDE_USAGES_RUBRIK_CLUSTER_CERTIFICATE_AUTHORITY,

        [EnumMember(Value = "EXCLUDE_USAGES_SECONDARY_AGENT")]
        EXCLUDE_USAGES_SECONDARY_AGENT,

        [EnumMember(Value = "EXCLUDE_USAGES_SMTP")]
        EXCLUDE_USAGES_SMTP,

        [EnumMember(Value = "EXCLUDE_USAGES_SSO_ENCRYPTION")]
        EXCLUDE_USAGES_SSO_ENCRYPTION,

        [EnumMember(Value = "EXCLUDE_USAGES_SSO_SIGNING")]
        EXCLUDE_USAGES_SSO_SIGNING,

        [EnumMember(Value = "EXCLUDE_USAGES_SYSLOG")]
        EXCLUDE_USAGES_SYSLOG,

        [EnumMember(Value = "EXCLUDE_USAGES_WEB_SERVER")]
        EXCLUDE_USAGES_WEB_SERVER


    } // enum ExcludeUsages

} // namespace RubrikSecurityCloud.Types