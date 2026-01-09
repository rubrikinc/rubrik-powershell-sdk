// PrincipalRiskySummaryPrincipalType.cs
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
    public enum PrincipalRiskySummaryPrincipalType
    {
        [EnumMember(Value = "ACCESS_POLICY")]
        ACCESS_POLICY,

        [EnumMember(Value = "ASSUMABLE_IDENTITY")]
        ASSUMABLE_IDENTITY,

        [EnumMember(Value = "ATTRIBUTE_SCHEMA")]
        ATTRIBUTE_SCHEMA,

        [EnumMember(Value = "CLASS_SCHEMA")]
        CLASS_SCHEMA,

        [EnumMember(Value = "COMPUTER")]
        COMPUTER,

        [EnumMember(Value = "CONTACT")]
        CONTACT,

        [EnumMember(Value = "CONTAINER")]
        CONTAINER,

        [EnumMember(Value = "DOMAIN_DNS")]
        DOMAIN_DNS,

        [EnumMember(Value = "EXTERNAL_ACCOUNT")]
        EXTERNAL_ACCOUNT,

        [EnumMember(Value = "EXTERNAL_PRINCIPAL")]
        EXTERNAL_PRINCIPAL,

        [EnumMember(Value = "FOREIGN_SECURITY_PRINCIPAL")]
        FOREIGN_SECURITY_PRINCIPAL,

        [EnumMember(Value = "GPO")]
        GPO,

        [EnumMember(Value = "GROUP")]
        GROUP,

        [EnumMember(Value = "INFRASTRUCTURE_UPDATE")]
        INFRASTRUCTURE_UPDATE,

        [EnumMember(Value = "INTER_SITE_TRANSPORT")]
        INTER_SITE_TRANSPORT,

        [EnumMember(Value = "INTER_SITE_TRANSPORT_CONTAINER")]
        INTER_SITE_TRANSPORT_CONTAINER,

        [EnumMember(Value = "LICENSING_SITE_SETTINGS")]
        LICENSING_SITE_SETTINGS,

        [EnumMember(Value = "MSDS_QUOTA_CONTAINER")]
        MSDS_QUOTA_CONTAINER,

        [EnumMember(Value = "MSDS_QUOTA_CONTROL")]
        MSDS_QUOTA_CONTROL,

        [EnumMember(Value = "NAMED_LOCATION")]
        NAMED_LOCATION,

        [EnumMember(Value = "NTDS_SITE_SETTINGS")]
        NTDS_SITE_SETTINGS,

        [EnumMember(Value = "ORG_WIDE")]
        ORG_WIDE,

        [EnumMember(Value = "OU")]
        OU,

        [EnumMember(Value = "PASSWORD_SETTINGS")]
        PASSWORD_SETTINGS,

        [EnumMember(Value = "PASSWORD_SETTINGS_CONTAINER")]
        PASSWORD_SETTINGS_CONTAINER,

        [EnumMember(Value = "PRINT_QUEUE")]
        PRINT_QUEUE,

        [EnumMember(Value = "PUBLIC")]
        PUBLIC,

        [EnumMember(Value = "RID_MANAGER")]
        RID_MANAGER,

        [EnumMember(Value = "SERVER")]
        SERVER,

        [EnumMember(Value = "SERVERS_CONTAINER")]
        SERVERS_CONTAINER,

        [EnumMember(Value = "SERVICE_ACCOUNT")]
        SERVICE_ACCOUNT,

        [EnumMember(Value = "SITE")]
        SITE,

        [EnumMember(Value = "SITE_LINK")]
        SITE_LINK,

        [EnumMember(Value = "SITE_LINK_BRIDGE")]
        SITE_LINK_BRIDGE,

        [EnumMember(Value = "SUBNET")]
        SUBNET,

        [EnumMember(Value = "SUBNET_CONTAINER")]
        SUBNET_CONTAINER,

        [EnumMember(Value = "TRUSTED_DOMAIN")]
        TRUSTED_DOMAIN,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "USER")]
        USER,

        [EnumMember(Value = "VOLUME")]
        VOLUME


    } // enum PrincipalRiskySummaryPrincipalType

} // namespace RubrikSecurityCloud.Types