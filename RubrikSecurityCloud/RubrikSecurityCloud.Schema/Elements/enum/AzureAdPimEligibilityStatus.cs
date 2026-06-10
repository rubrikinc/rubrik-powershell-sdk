// AzureAdPimEligibilityStatus.cs
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
    public enum AzureAdPimEligibilityStatus
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "PIM_ELIGIBILITY_STATUS_CANCELED")]
        PIM_ELIGIBILITY_STATUS_CANCELED,

        [EnumMember(Value = "PIM_ELIGIBILITY_STATUS_DENIED")]
        PIM_ELIGIBILITY_STATUS_DENIED,

        [EnumMember(Value = "PIM_ELIGIBILITY_STATUS_FAILED")]
        PIM_ELIGIBILITY_STATUS_FAILED,

        [EnumMember(Value = "PIM_ELIGIBILITY_STATUS_GRANTED")]
        PIM_ELIGIBILITY_STATUS_GRANTED,

        [EnumMember(Value = "PIM_ELIGIBILITY_STATUS_PENDING_ADMIN_DECISION")]
        PIM_ELIGIBILITY_STATUS_PENDING_ADMIN_DECISION,

        [EnumMember(Value = "PIM_ELIGIBILITY_STATUS_PENDING_APPROVAL")]
        PIM_ELIGIBILITY_STATUS_PENDING_APPROVAL,

        [EnumMember(Value = "PIM_ELIGIBILITY_STATUS_PENDING_PROVISIONING")]
        PIM_ELIGIBILITY_STATUS_PENDING_PROVISIONING,

        [EnumMember(Value = "PIM_ELIGIBILITY_STATUS_PENDING_SCHEDULE_CREATION")]
        PIM_ELIGIBILITY_STATUS_PENDING_SCHEDULE_CREATION,

        [EnumMember(Value = "PIM_ELIGIBILITY_STATUS_PROVISIONED")]
        PIM_ELIGIBILITY_STATUS_PROVISIONED,

        [EnumMember(Value = "PIM_ELIGIBILITY_STATUS_REVOKED")]
        PIM_ELIGIBILITY_STATUS_REVOKED,

        [EnumMember(Value = "PIM_ELIGIBILITY_STATUS_SCHEDULE_CREATED")]
        PIM_ELIGIBILITY_STATUS_SCHEDULE_CREATED,

        [EnumMember(Value = "PIM_ELIGIBILITY_STATUS_UNSPECIFIED")]
        PIM_ELIGIBILITY_STATUS_UNSPECIFIED


    } // enum AzureAdPimEligibilityStatus

} // namespace RubrikSecurityCloud.Types