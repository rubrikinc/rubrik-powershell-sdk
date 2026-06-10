// PolicyViolationStatusReason.cs
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
    public enum PolicyViolationStatusReason
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "POLICY_VIOLATION_STATUS_REASON_ASSET_DELETED")]
        POLICY_VIOLATION_STATUS_REASON_ASSET_DELETED,

        [EnumMember(Value = "POLICY_VIOLATION_STATUS_REASON_ASSET_UNCLASSIFIABLE")]
        POLICY_VIOLATION_STATUS_REASON_ASSET_UNCLASSIFIABLE,

        [EnumMember(Value = "POLICY_VIOLATION_STATUS_REASON_AUTO_REMEDIATED")]
        POLICY_VIOLATION_STATUS_REASON_AUTO_REMEDIATED,

        [EnumMember(Value = "POLICY_VIOLATION_STATUS_REASON_DISMISSED")]
        POLICY_VIOLATION_STATUS_REASON_DISMISSED,

        [EnumMember(Value = "POLICY_VIOLATION_STATUS_REASON_OPEN")]
        POLICY_VIOLATION_STATUS_REASON_OPEN,

        [EnumMember(Value = "POLICY_VIOLATION_STATUS_REASON_POLICY_DELETED")]
        POLICY_VIOLATION_STATUS_REASON_POLICY_DELETED,

        [EnumMember(Value = "POLICY_VIOLATION_STATUS_REASON_POLICY_DISABLED")]
        POLICY_VIOLATION_STATUS_REASON_POLICY_DISABLED,

        [EnumMember(Value = "POLICY_VIOLATION_STATUS_REASON_POLICY_MODIFIED")]
        POLICY_VIOLATION_STATUS_REASON_POLICY_MODIFIED,

        [EnumMember(Value = "POLICY_VIOLATION_STATUS_REASON_POLICY_OTHER")]
        POLICY_VIOLATION_STATUS_REASON_POLICY_OTHER,

        [EnumMember(Value = "POLICY_VIOLATION_STATUS_REASON_REMEDIATED")]
        POLICY_VIOLATION_STATUS_REASON_REMEDIATED,

        [EnumMember(Value = "POLICY_VIOLATION_STATUS_REASON_UNSPECIFIED")]
        POLICY_VIOLATION_STATUS_REASON_UNSPECIFIED


    } // enum PolicyViolationStatusReason

} // namespace RubrikSecurityCloud.Types