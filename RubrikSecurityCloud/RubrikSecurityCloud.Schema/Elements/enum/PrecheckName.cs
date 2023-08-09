// PrecheckName.cs
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
    public enum PrecheckName
    {
        [EnumMember(Value = "ARCHIVAL_MIGRATION")]
        ARCHIVAL_MIGRATION,

        [EnumMember(Value = "AUTOMATIC_MIGRATION")]
        AUTOMATIC_MIGRATION,

        [EnumMember(Value = "CLOUD_ON_MIGRATION")]
        CLOUD_ON_MIGRATION,

        [EnumMember(Value = "EC2_MIGRATION")]
        EC2_MIGRATION,

        [EnumMember(Value = "EMAIL_NOTIFICATION_MIGRATION")]
        EMAIL_NOTIFICATION_MIGRATION,

        [EnumMember(Value = "MANAGED_VOLUME_MIGRATION")]
        MANAGED_VOLUME_MIGRATION,

        [EnumMember(Value = "MULTI_TENANCY_MIGRATION")]
        MULTI_TENANCY_MIGRATION,

        [EnumMember(Value = "NAS_MIGRATION")]
        NAS_MIGRATION,

        [EnumMember(Value = "REPORTS_MIGRATION")]
        REPORTS_MIGRATION,

        [EnumMember(Value = "REST_API_MIGRATION")]
        REST_API_MIGRATION,

        [EnumMember(Value = "SLA_MIGRATION")]
        SLA_MIGRATION,

        [EnumMember(Value = "TPR_MIGRATION")]
        TPR_MIGRATION,

        [EnumMember(Value = "USER_ROLES_SSO_MIGRATION")]
        USER_ROLES_SSO_MIGRATION


    } // enum PrecheckName

} // namespace RubrikSecurityCloud.Types