// SaasOrgType.cs
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
    public enum SaasOrgType
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "ATLASSIAN_ORG")]
        ATLASSIAN_ORG,

        [EnumMember(Value = "DYNAMICS_365_ORG")]
        DYNAMICS_365_ORG,

        [EnumMember(Value = "GOOGLE_WORKSPACE_ORG")]
        GOOGLE_WORKSPACE_ORG,

        [EnumMember(Value = "M365_BACKUP_STORAGE_ORG")]
        M365_BACKUP_STORAGE_ORG,

        [EnumMember(Value = "OKTA_ORG")]
        OKTA_ORG,

        [EnumMember(Value = "SAAS_ORG_TYPE_UNSPECIFIED")]
        SAAS_ORG_TYPE_UNSPECIFIED,

        [EnumMember(Value = "SALESFORCE_ORG")]
        SALESFORCE_ORG,

        [EnumMember(Value = "SLACK_ORG")]
        SLACK_ORG


    } // enum SaasOrgType

} // namespace RubrikSecurityCloud.Types