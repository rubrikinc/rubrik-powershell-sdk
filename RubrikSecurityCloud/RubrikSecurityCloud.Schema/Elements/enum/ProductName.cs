// ProductName.cs
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
    public enum ProductName
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "AAD")]
        AAD,

        [EnumMember(Value = "AAD_CYBER_POSTURE")]
        AAD_CYBER_POSTURE,

        [EnumMember(Value = "AAD_CYBER_RECOVERY")]
        AAD_CYBER_RECOVERY,

        [EnumMember(Value = "ANNAPURNA")]
        ANNAPURNA,

        [EnumMember(Value = "APPFLOWS")]
        APPFLOWS,

        [EnumMember(Value = "APPFLOWS_UCL")]
        APPFLOWS_UCL,

        [EnumMember(Value = "ATLASSIAN_JIRA")]
        ATLASSIAN_JIRA,

        [EnumMember(Value = "CC_ES")]
        CC_ES,

        [EnumMember(Value = "CLOUDNATIVE")]
        CLOUDNATIVE,

        [EnumMember(Value = "CLOUD_UNSTRUCTURED")]
        CLOUD_UNSTRUCTURED,

        [EnumMember(Value = "DYNAMICS_365")]
        DYNAMICS_365,

        [EnumMember(Value = "GPS")]
        GPS,

        [EnumMember(Value = "KUBERNETES")]
        KUBERNETES,

        [EnumMember(Value = "LAMINAR")]
        LAMINAR,

        [EnumMember(Value = "LAMINAR_LITE_UCL")]
        LAMINAR_LITE_UCL,

        [EnumMember(Value = "M365_BACKUP_STORAGE")]
        M365_BACKUP_STORAGE,

        [EnumMember(Value = "NAS_CLOUDDIRECT")]
        NAS_CLOUDDIRECT,

        [EnumMember(Value = "NOSQL")]
        NOSQL,

        [EnumMember(Value = "O365")]
        O365,

        [EnumMember(Value = "ONPREM_AD")]
        ONPREM_AD,

        [EnumMember(Value = "ONPREM_AD_CP")]
        ONPREM_AD_CP,

        [EnumMember(Value = "ONPREM_AD_CR")]
        ONPREM_AD_CR,

        [EnumMember(Value = "RADAR")]
        RADAR,

        [EnumMember(Value = "RADAR_CLU")]
        RADAR_CLU,

        [EnumMember(Value = "RADAR_NAS")]
        RADAR_NAS,

        [EnumMember(Value = "RADAR_UCL")]
        RADAR_UCL,

        [EnumMember(Value = "RCV")]
        RCV,

        [EnumMember(Value = "RCV_UCL")]
        RCV_UCL,

        [EnumMember(Value = "RDP")]
        RDP,

        [EnumMember(Value = "SALESFORCE")]
        SALESFORCE,

        [EnumMember(Value = "SALESFORCE_DEVOPS_ADD_ON")]
        SALESFORCE_DEVOPS_ADD_ON,

        [EnumMember(Value = "SAPHANA")]
        SAPHANA,

        [EnumMember(Value = "SONAR")]
        SONAR,

        [EnumMember(Value = "SONAR_NAS")]
        SONAR_NAS,

        [EnumMember(Value = "SONAR_O365")]
        SONAR_O365,

        [EnumMember(Value = "SONAR_UCL")]
        SONAR_UCL,

        [EnumMember(Value = "UNSPECIFIED_NAME")]
        UNSPECIFIED_NAME,

        [EnumMember(Value = "USER_ACCESS")]
        USER_ACCESS,

        [EnumMember(Value = "USER_INTELLIGENCE")]
        USER_INTELLIGENCE


    } // enum ProductName

} // namespace RubrikSecurityCloud.Types