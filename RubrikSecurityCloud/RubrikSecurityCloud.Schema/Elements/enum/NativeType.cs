// NativeType.cs
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
    public enum NativeType
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "AD_ATTRIBUTE_SCHEMA")]
        AD_ATTRIBUTE_SCHEMA,

        [EnumMember(Value = "AD_CERTIFICATE_TEMPLATE")]
        AD_CERTIFICATE_TEMPLATE,

        [EnumMember(Value = "AD_CLASS_SCHEMA")]
        AD_CLASS_SCHEMA,

        [EnumMember(Value = "AD_COMPUTER")]
        AD_COMPUTER,

        [EnumMember(Value = "AD_CONTACT")]
        AD_CONTACT,

        [EnumMember(Value = "AD_CONTAINER")]
        AD_CONTAINER,

        [EnumMember(Value = "AD_CONTROL_ACCESS_RIGHT")]
        AD_CONTROL_ACCESS_RIGHT,

        [EnumMember(Value = "AD_CROSS_REF")]
        AD_CROSS_REF,

        [EnumMember(Value = "AD_CROSS_REF_CONTAINER")]
        AD_CROSS_REF_CONTAINER,

        [EnumMember(Value = "AD_DFS_LINK")]
        AD_DFS_LINK,

        [EnumMember(Value = "AD_DFS_NAMESPACE_V1")]
        AD_DFS_NAMESPACE_V1,

        [EnumMember(Value = "AD_DFS_NAMESPACE_V2")]
        AD_DFS_NAMESPACE_V2,

        [EnumMember(Value = "AD_DMD")]
        AD_DMD,

        [EnumMember(Value = "AD_DNS_NODE")]
        AD_DNS_NODE,

        [EnumMember(Value = "AD_DNS_ZONE")]
        AD_DNS_ZONE,

        [EnumMember(Value = "AD_DOMAIN_DNS")]
        AD_DOMAIN_DNS,

        [EnumMember(Value = "AD_DOMAIN_INFRASTRUCTURE")]
        AD_DOMAIN_INFRASTRUCTURE,

        [EnumMember(Value = "AD_FOREIGN_SECURITY_PRINCIPAL")]
        AD_FOREIGN_SECURITY_PRINCIPAL,

        [EnumMember(Value = "AD_GMSA")]
        AD_GMSA,

        [EnumMember(Value = "AD_GPO")]
        AD_GPO,

        [EnumMember(Value = "AD_GROUP")]
        AD_GROUP,

        [EnumMember(Value = "AD_INFRASTRUCTURE_UPDATE")]
        AD_INFRASTRUCTURE_UPDATE,

        [EnumMember(Value = "AD_INTER_SITE_TRANSPORT")]
        AD_INTER_SITE_TRANSPORT,

        [EnumMember(Value = "AD_INTER_SITE_TRANSPORT_CONTAINER")]
        AD_INTER_SITE_TRANSPORT_CONTAINER,

        [EnumMember(Value = "AD_LICENSING_SITE_SETTINGS")]
        AD_LICENSING_SITE_SETTINGS,

        [EnumMember(Value = "AD_MSDS_QUOTA_CONTAINER")]
        AD_MSDS_QUOTA_CONTAINER,

        [EnumMember(Value = "AD_MSDS_QUOTA_CONTROL")]
        AD_MSDS_QUOTA_CONTROL,

        [EnumMember(Value = "AD_MSKDS_PROV_ROOT_KEY")]
        AD_MSKDS_PROV_ROOT_KEY,

        [EnumMember(Value = "AD_NTDS_SITE_SETTINGS")]
        AD_NTDS_SITE_SETTINGS,

        [EnumMember(Value = "AD_NTFRS_SUBSCRIBER")]
        AD_NTFRS_SUBSCRIBER,

        [EnumMember(Value = "AD_OU")]
        AD_OU,

        [EnumMember(Value = "AD_PASSWORD_SETTINGS")]
        AD_PASSWORD_SETTINGS,

        [EnumMember(Value = "AD_PASSWORD_SETTINGS_CONTAINER")]
        AD_PASSWORD_SETTINGS_CONTAINER,

        [EnumMember(Value = "AD_PKI_ENROLLMENT_SERVICE")]
        AD_PKI_ENROLLMENT_SERVICE,

        [EnumMember(Value = "AD_PRINT_QUEUE")]
        AD_PRINT_QUEUE,

        [EnumMember(Value = "AD_QUERY_POLICY")]
        AD_QUERY_POLICY,

        [EnumMember(Value = "AD_RID_MANAGER")]
        AD_RID_MANAGER,

        [EnumMember(Value = "AD_SERVER")]
        AD_SERVER,

        [EnumMember(Value = "AD_SERVERS_CONTAINER")]
        AD_SERVERS_CONTAINER,

        [EnumMember(Value = "AD_SITE")]
        AD_SITE,

        [EnumMember(Value = "AD_SITE_LINK")]
        AD_SITE_LINK,

        [EnumMember(Value = "AD_SITE_LINK_BRIDGE")]
        AD_SITE_LINK_BRIDGE,

        [EnumMember(Value = "AD_SMSA")]
        AD_SMSA,

        [EnumMember(Value = "AD_SUBNET")]
        AD_SUBNET,

        [EnumMember(Value = "AD_SUBNET_CONTAINER")]
        AD_SUBNET_CONTAINER,

        [EnumMember(Value = "AD_SYSTEM_IDENTITY")]
        AD_SYSTEM_IDENTITY,

        [EnumMember(Value = "AD_TRUSTED_DOMAIN")]
        AD_TRUSTED_DOMAIN,

        [EnumMember(Value = "AD_USER")]
        AD_USER,

        [EnumMember(Value = "AD_VOLUME")]
        AD_VOLUME,

        [EnumMember(Value = "ENTRA_ID_ADMINISTRATIVE_UNIT")]
        ENTRA_ID_ADMINISTRATIVE_UNIT,

        [EnumMember(Value = "ENTRA_ID_AGENT_ID")]
        ENTRA_ID_AGENT_ID,

        [EnumMember(Value = "ENTRA_ID_APP_ROLE")]
        ENTRA_ID_APP_ROLE,

        [EnumMember(Value = "ENTRA_ID_APP_ROLE_ASSIGNMENT")]
        ENTRA_ID_APP_ROLE_ASSIGNMENT,

        [EnumMember(Value = "ENTRA_ID_AUTHENTICATION_CONTEXT")]
        ENTRA_ID_AUTHENTICATION_CONTEXT,

        [EnumMember(Value = "ENTRA_ID_AUTHENTICATION_STRENGTH")]
        ENTRA_ID_AUTHENTICATION_STRENGTH,

        [EnumMember(Value = "ENTRA_ID_CONDITIONAL_ACCESS_POLICY")]
        ENTRA_ID_CONDITIONAL_ACCESS_POLICY,

        [EnumMember(Value = "ENTRA_ID_CONTRACT")]
        ENTRA_ID_CONTRACT,

        [EnumMember(Value = "ENTRA_ID_DEVICE")]
        ENTRA_ID_DEVICE,

        [EnumMember(Value = "ENTRA_ID_DIRECTORY_ROLE")]
        ENTRA_ID_DIRECTORY_ROLE,

        [EnumMember(Value = "ENTRA_ID_GROUP")]
        ENTRA_ID_GROUP,

        [EnumMember(Value = "ENTRA_ID_INVITATION")]
        ENTRA_ID_INVITATION,

        [EnumMember(Value = "ENTRA_ID_MANAGED_IDENTITY")]
        ENTRA_ID_MANAGED_IDENTITY,

        [EnumMember(Value = "ENTRA_ID_NAMED_LOCATION")]
        ENTRA_ID_NAMED_LOCATION,

        [EnumMember(Value = "ENTRA_ID_OAUTH2_PERMISSION_GRANT")]
        ENTRA_ID_OAUTH2_PERMISSION_GRANT,

        [EnumMember(Value = "ENTRA_ID_OTHER")]
        ENTRA_ID_OTHER,

        [EnumMember(Value = "ENTRA_ID_ROLE")]
        ENTRA_ID_ROLE,

        [EnumMember(Value = "ENTRA_ID_SERVICE_PRINCIPAL")]
        ENTRA_ID_SERVICE_PRINCIPAL,

        [EnumMember(Value = "ENTRA_ID_TERMS_OF_USE")]
        ENTRA_ID_TERMS_OF_USE,

        [EnumMember(Value = "ENTRA_ID_USER")]
        ENTRA_ID_USER,

        [EnumMember(Value = "OKTA_APPLICATION")]
        OKTA_APPLICATION,

        [EnumMember(Value = "OKTA_GROUP")]
        OKTA_GROUP,

        [EnumMember(Value = "OKTA_POLICY")]
        OKTA_POLICY,

        [EnumMember(Value = "OKTA_USER")]
        OKTA_USER,

        [EnumMember(Value = "OKTA_USER_TYPE")]
        OKTA_USER_TYPE,

        [EnumMember(Value = "UNKNOWN_NATIVE_TYPE")]
        UNKNOWN_NATIVE_TYPE


    } // enum NativeType

} // namespace RubrikSecurityCloud.Types