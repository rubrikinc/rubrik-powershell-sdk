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
        [EnumMember(Value = "ATLASSIAN_JIRA")]
        ATLASSIAN_JIRA,

        [EnumMember(Value = "M365_BACKUP_STORAGE")]
        M365_BACKUP_STORAGE,

        [EnumMember(Value = "SALESFORCE")]
        SALESFORCE,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN


    } // enum SaasAppType

} // namespace RubrikSecurityCloud.Types