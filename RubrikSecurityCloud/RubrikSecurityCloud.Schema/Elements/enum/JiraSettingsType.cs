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

namespace Rubrik.SecurityCloud.Types
{
    public enum JiraSettingsType
    {
        [EnumMember(Value = "APPLICATION_ROLE")]
        APPLICATION_ROLE,

        [EnumMember(Value = "CUSTOM_FIELDS")]
        CUSTOM_FIELDS,

        [EnumMember(Value = "CUSTOM_FIELD_CONTEXT")]
        CUSTOM_FIELD_CONTEXT,

        [EnumMember(Value = "DASHBOARDS")]
        DASHBOARDS,

        [EnumMember(Value = "FIELD_CONFIGURATION")]
        FIELD_CONFIGURATION,

        [EnumMember(Value = "FIELD_CONFIGURATION_SCHEMES")]
        FIELD_CONFIGURATION_SCHEMES,

        [EnumMember(Value = "FILTERS")]
        FILTERS,

        [EnumMember(Value = "GLOBAL_PERMISSIONS")]
        GLOBAL_PERMISSIONS,

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

        [EnumMember(Value = "JIRA_SETTINGS_TYPE_UNSPECIFIED")]
        JIRA_SETTINGS_TYPE_UNSPECIFIED,

        [EnumMember(Value = "NOTIFICATION_SCHEMES")]
        NOTIFICATION_SCHEMES,

        [EnumMember(Value = "PERMISSION_SCHEMES")]
        PERMISSION_SCHEMES,

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
        WORKFLOW_SCHEMES


    } // enum JiraSettingsType

} // namespace Rubrik.SecurityCloud.Types