// ViolationPrincipalType.cs
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
    public enum ViolationPrincipalType
    {
        [EnumMember(Value = "ACCESS_POLICY")]
        ACCESS_POLICY,

        [EnumMember(Value = "APP_ROLE")]
        APP_ROLE,

        [EnumMember(Value = "ASSUMABLE_IDENTITY")]
        ASSUMABLE_IDENTITY,

        [EnumMember(Value = "ATTRIBUTE_SCHEMA")]
        ATTRIBUTE_SCHEMA,

        [EnumMember(Value = "AU")]
        AU,

        [EnumMember(Value = "AUTHENTICATION_CONTEXT")]
        AUTHENTICATION_CONTEXT,

        [EnumMember(Value = "AUTHENTICATION_STRENGTH")]
        AUTHENTICATION_STRENGTH,

        [EnumMember(Value = "CERTIFICATE_TEMPLATE")]
        CERTIFICATE_TEMPLATE,

        [EnumMember(Value = "CLASS_SCHEMA")]
        CLASS_SCHEMA,

        [EnumMember(Value = "COMPUTER")]
        COMPUTER,

        [EnumMember(Value = "CONTACT")]
        CONTACT,

        [EnumMember(Value = "CONTAINER")]
        CONTAINER,

        [EnumMember(Value = "CONTRACT")]
        CONTRACT,

        [EnumMember(Value = "CONTROL_ACCESS_RIGHT")]
        CONTROL_ACCESS_RIGHT,

        [EnumMember(Value = "DEVICE")]
        DEVICE,

        [EnumMember(Value = "DFS_LINK")]
        DFS_LINK,

        [EnumMember(Value = "DFS_NAMESPACE_V1")]
        DFS_NAMESPACE_V1,

        [EnumMember(Value = "DFS_NAMESPACE_V2")]
        DFS_NAMESPACE_V2,

        [EnumMember(Value = "DNS_NODE")]
        DNS_NODE,

        [EnumMember(Value = "DNS_ZONE")]
        DNS_ZONE,

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

        [EnumMember(Value = "INVITATION")]
        INVITATION,

        [EnumMember(Value = "LICENSING_SITE_SETTINGS")]
        LICENSING_SITE_SETTINGS,

        [EnumMember(Value = "MSDS_QUOTA_CONTAINER")]
        MSDS_QUOTA_CONTAINER,

        [EnumMember(Value = "MSDS_QUOTA_CONTROL")]
        MSDS_QUOTA_CONTROL,

        [EnumMember(Value = "MSKDS_PROV_ROOT_KEY")]
        MSKDS_PROV_ROOT_KEY,

        [EnumMember(Value = "NAMED_LOCATION")]
        NAMED_LOCATION,

        [EnumMember(Value = "NTDS_SITE_SETTINGS")]
        NTDS_SITE_SETTINGS,

        [EnumMember(Value = "NTFRS_SUBSCRIBER")]
        NTFRS_SUBSCRIBER,

        [EnumMember(Value = "OAUTH2_PERMISSION_GRANT")]
        OAUTH2_PERMISSION_GRANT,

        [EnumMember(Value = "ORG_WIDE")]
        ORG_WIDE,

        [EnumMember(Value = "OTHER")]
        OTHER,

        [EnumMember(Value = "OU")]
        OU,

        [EnumMember(Value = "PASSWORD_SETTINGS")]
        PASSWORD_SETTINGS,

        [EnumMember(Value = "PASSWORD_SETTINGS_CONTAINER")]
        PASSWORD_SETTINGS_CONTAINER,

        [EnumMember(Value = "PKI_ENROLLMENT_SERVICE")]
        PKI_ENROLLMENT_SERVICE,

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

        [EnumMember(Value = "SYSTEM_IDENTITY")]
        SYSTEM_IDENTITY,

        [EnumMember(Value = "TERMS_OF_USE")]
        TERMS_OF_USE,

        [EnumMember(Value = "TRUSTED_DOMAIN")]
        TRUSTED_DOMAIN,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "USER")]
        USER,

        [EnumMember(Value = "VOLUME")]
        VOLUME


    } // enum ViolationPrincipalType

} // namespace RubrikSecurityCloud.Types