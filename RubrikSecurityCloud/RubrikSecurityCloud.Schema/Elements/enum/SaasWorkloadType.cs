// SaasWorkloadType.cs
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
    public enum SaasWorkloadType
    {
        [EnumMember(Value = "CONFLUENCE_SPACE")]
        CONFLUENCE_SPACE,

        [EnumMember(Value = "JIRA_FEATURES")]
        JIRA_FEATURES,

        [EnumMember(Value = "JIRA_PROJECT")]
        JIRA_PROJECT,

        [EnumMember(Value = "JIRA_SETTINGS")]
        JIRA_SETTINGS,

        [EnumMember(Value = "SALESFORCE_METADATA")]
        SALESFORCE_METADATA,

        [EnumMember(Value = "SALESFORCE_OBJECT")]
        SALESFORCE_OBJECT,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN


    } // enum SaasWorkloadType

} // namespace RubrikSecurityCloud.Types