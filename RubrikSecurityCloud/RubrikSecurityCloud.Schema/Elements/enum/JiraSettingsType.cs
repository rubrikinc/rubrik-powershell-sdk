// JiraSettingsType.cs
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
    public enum JiraSettingsType
    {
        [EnumMember(Value = "CUSTOM_FIELDS")]
        CUSTOM_FIELDS,

        [EnumMember(Value = "DASHBOARDS")]
        DASHBOARDS,

        [EnumMember(Value = "FIELD_CONFIGURATION")]
        FIELD_CONFIGURATION,

        [EnumMember(Value = "FIELD_CONFIGURATION_SCHEMES")]
        FIELD_CONFIGURATION_SCHEMES,

        [EnumMember(Value = "FILTERS")]
        FILTERS,

        [EnumMember(Value = "GROUPS")]
        GROUPS,

        [EnumMember(Value = "ISSUE_PRIORITY")]
        ISSUE_PRIORITY,

        [EnumMember(Value = "ISSUE_RESOLUTION")]
        ISSUE_RESOLUTION,

        [EnumMember(Value = "ISSUE_SECURITY_SCHEMES")]
        ISSUE_SECURITY_SCHEMES,

        [EnumMember(Value = "ISSUE_STATUS")]
        ISSUE_STATUS,

        [EnumMember(Value = "ISSUE_TYPES")]
        ISSUE_TYPES,

        [EnumMember(Value = "ISSUE_TYPE_SCHEME")]
        ISSUE_TYPE_SCHEME,

        [EnumMember(Value = "ISSUE_TYPE_SCREEN_SCHEME")]
        ISSUE_TYPE_SCREEN_SCHEME,

        [EnumMember(Value = "NOTIFICATION_SCHEMES")]
        NOTIFICATION_SCHEMES,

        [EnumMember(Value = "PERMISSION_SCHEMES")]
        PERMISSION_SCHEMES,

        [EnumMember(Value = "PROJECT_CATEGORY")]
        PROJECT_CATEGORY,

        [EnumMember(Value = "PROJECT_ROLES")]
        PROJECT_ROLES,

        [EnumMember(Value = "SCREENS")]
        SCREENS,

        [EnumMember(Value = "SCREEN_SCHEMES")]
        SCREEN_SCHEMES,

        [EnumMember(Value = "USER")]
        USER,

        [EnumMember(Value = "WORKFLOWS")]
        WORKFLOWS,

        [EnumMember(Value = "WORKFLOW_SCHEMES")]
        WORKFLOW_SCHEMES,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN


    } // enum JiraSettingsType

} // namespace RubrikSecurityCloud.Types