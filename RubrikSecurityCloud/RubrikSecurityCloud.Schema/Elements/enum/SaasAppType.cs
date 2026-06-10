// SaasAppType.cs
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
    public enum SaasAppType
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "ATLASSIAN_CONFLUENCE")]
        ATLASSIAN_CONFLUENCE,

        [EnumMember(Value = "ATLASSIAN_JIRA")]
        ATLASSIAN_JIRA,

        [EnumMember(Value = "AUTH0")]
        AUT_H0,

        [EnumMember(Value = "DYNAMICS_365")]
        DYNAMICS_365,

        [EnumMember(Value = "ENTRA_ID")]
        ENTRA_ID,

        [EnumMember(Value = "EXCHANGE")]
        EXCHANGE,

        [EnumMember(Value = "GOOGLE_DRIVE")]
        GOOGLE_DRIVE,

        [EnumMember(Value = "GOOGLE_MAIL")]
        GOOGLE_MAIL,

        [EnumMember(Value = "M365_BACKUP_STORAGE")]
        M365_BACKUP_STORAGE,

        [EnumMember(Value = "O365_COMMON")]
        O365_COMMON,

        [EnumMember(Value = "OKTA")]
        OKTA,

        [EnumMember(Value = "ONEDRIVE")]
        ONEDRIVE,

        [EnumMember(Value = "POWER_PLATFORM_APP")]
        POWER_PLATFORM_APP,

        [EnumMember(Value = "POWER_PLATFORM_FLOW")]
        POWER_PLATFORM_FLOW,

        [EnumMember(Value = "SAAS_AZURE_DEVOPS")]
        SAAS_AZURE_DEVOPS,

        [EnumMember(Value = "SAAS_GITHUB")]
        SAAS_GITHUB,

        [EnumMember(Value = "SALESFORCE")]
        SALESFORCE,

        [EnumMember(Value = "SHAREPOINT")]
        SHAREPOINT,

        [EnumMember(Value = "SLACK")]
        SLACK,

        [EnumMember(Value = "TEAMS")]
        TEAMS


    } // enum SaasAppType

} // namespace RubrikSecurityCloud.Types