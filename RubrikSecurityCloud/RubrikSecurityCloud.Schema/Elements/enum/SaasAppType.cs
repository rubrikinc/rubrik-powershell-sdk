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

        [EnumMember(Value = "DYNAMICS_365")]
        DYNAMICS_365,

        [EnumMember(Value = "ENTRA_ID")]
        ENTRA_ID,

        [EnumMember(Value = "GOOGLE_DRIVE")]
        GOOGLE_DRIVE,

        [EnumMember(Value = "GOOGLE_MAIL")]
        GOOGLE_MAIL,

        [EnumMember(Value = "M365_BACKUP_STORAGE")]
        M365_BACKUP_STORAGE,

        [EnumMember(Value = "OKTA")]
        OKTA,

        [EnumMember(Value = "SALESFORCE")]
        SALESFORCE,

        [EnumMember(Value = "SLACK")]
        SLACK


    } // enum SaasAppType

} // namespace RubrikSecurityCloud.Types