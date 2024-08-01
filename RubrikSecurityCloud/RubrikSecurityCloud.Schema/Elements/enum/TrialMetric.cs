// TrialMetric.cs
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
    public enum TrialMetric
    {
        [EnumMember(Value = "ATLASSIAN_JIRA_ATTACHMENTS_PROTECTED")]
        ATLASSIAN_JIRA_ATTACHMENTS_PROTECTED,

        [EnumMember(Value = "ATLASSIAN_JIRA_ISSUES_PROTECTED")]
        ATLASSIAN_JIRA_ISSUES_PROTECTED,

        [EnumMember(Value = "ATLASSIAN_JIRA_ISSUES_RECOVERED")]
        ATLASSIAN_JIRA_ISSUES_RECOVERED,

        [EnumMember(Value = "ATLASSIAN_JIRA_ISSUE_RECOVERIES")]
        ATLASSIAN_JIRA_ISSUE_RECOVERIES,

        [EnumMember(Value = "ATLASSIAN_JIRA_MOST_USED_SLA_FREQUENCY")]
        ATLASSIAN_JIRA_MOST_USED_SLA_FREQUENCY,

        [EnumMember(Value = "ATLASSIAN_JIRA_MOST_USED_SLA_NAME")]
        ATLASSIAN_JIRA_MOST_USED_SLA_NAME,

        [EnumMember(Value = "ATLASSIAN_JIRA_MOST_USED_SLA_RETENTION")]
        ATLASSIAN_JIRA_MOST_USED_SLA_RETENTION,

        [EnumMember(Value = "ATLASSIAN_JIRA_PROJECTS_BACKUPS")]
        ATLASSIAN_JIRA_PROJECTS_BACKUPS,

        [EnumMember(Value = "ATLASSIAN_JIRA_PROJECTS_PROTECTED")]
        ATLASSIAN_JIRA_PROJECTS_PROTECTED,

        [EnumMember(Value = "ATLASSIAN_JIRA_SETTINGS_BACKUPS")]
        ATLASSIAN_JIRA_SETTINGS_BACKUPS,

        [EnumMember(Value = "ATLASSIAN_JIRA_SETTINGS_PROTECTED")]
        ATLASSIAN_JIRA_SETTINGS_PROTECTED,

        [EnumMember(Value = "ATLASSIAN_JIRA_SETTINGS_RECOVERED")]
        ATLASSIAN_JIRA_SETTINGS_RECOVERED,

        [EnumMember(Value = "ATLASSIAN_JIRA_SETTINGS_RECOVERIES")]
        ATLASSIAN_JIRA_SETTINGS_RECOVERIES,

        [EnumMember(Value = "ATLASSIAN_JIRA_USER_LICENSES")]
        ATLASSIAN_JIRA_USER_LICENSES,

        [EnumMember(Value = "M365_DEFAULT_POLICIES_APPLIED")]
        M365_DEFAULT_POLICIES_APPLIED,

        [EnumMember(Value = "M365_EXCHANGE_OBJECTS_BACKUPS")]
        M365_EXCHANGE_OBJECTS_BACKUPS,

        [EnumMember(Value = "M365_EXCHANGE_OBJECTS_PROTECTED")]
        M365_EXCHANGE_OBJECTS_PROTECTED,

        [EnumMember(Value = "M365_EXCHANGE_RECOVERIES")]
        M365_EXCHANGE_RECOVERIES,

        [EnumMember(Value = "M365_MOST_USED_SLA_FREQUENCY")]
        M365_MOST_USED_SLA_FREQUENCY,

        [EnumMember(Value = "M365_MOST_USED_SLA_NAME")]
        M365_MOST_USED_SLA_NAME,

        [EnumMember(Value = "M365_MOST_USED_SLA_RETENTION")]
        M365_MOST_USED_SLA_RETENTION,

        [EnumMember(Value = "M365_ONE_DRIVE_OBJECTS_BACKUPS")]
        M365_ONE_DRIVE_OBJECTS_BACKUPS,

        [EnumMember(Value = "M365_ONE_DRIVE_OBJECTS_PROTECTED")]
        M365_ONE_DRIVE_OBJECTS_PROTECTED,

        [EnumMember(Value = "M365_ONE_DRIVE_RECOVERIES")]
        M365_ONE_DRIVE_RECOVERIES,

        [EnumMember(Value = "M365_SENSITIVE_FILES_DISCOVERED")]
        M365_SENSITIVE_FILES_DISCOVERED,

        [EnumMember(Value = "M365_SHAREPOINT_OBJECTS_BACKUPS")]
        M365_SHAREPOINT_OBJECTS_BACKUPS,

        [EnumMember(Value = "M365_SHAREPOINT_OBJECTS_PROTECTED")]
        M365_SHAREPOINT_OBJECTS_PROTECTED,

        [EnumMember(Value = "M365_SHAREPOINT_RECOVERIES")]
        M365_SHAREPOINT_RECOVERIES,

        [EnumMember(Value = "M365_TEAMS_OBJECTS_BACKUPS")]
        M365_TEAMS_OBJECTS_BACKUPS,

        [EnumMember(Value = "M365_TEAMS_OBJECTS_PROTECTED")]
        M365_TEAMS_OBJECTS_PROTECTED,

        [EnumMember(Value = "M365_TEAMS_RECOVERIES")]
        M365_TEAMS_RECOVERIES,

        [EnumMember(Value = "M365_TOTAL_POLICIES_APPLIED")]
        M365_TOTAL_POLICIES_APPLIED,

        [EnumMember(Value = "M365_TOTAL_STORAGE_USED")]
        M365_TOTAL_STORAGE_USED,

        [EnumMember(Value = "METRIC_TYPE_UNSPECIFIED")]
        METRIC_TYPE_UNSPECIFIED,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN


    } // enum TrialMetric

} // namespace RubrikSecurityCloud.Types