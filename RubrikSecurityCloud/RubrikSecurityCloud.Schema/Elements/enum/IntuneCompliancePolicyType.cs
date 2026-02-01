// IntuneCompliancePolicyType.cs
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
    public enum IntuneCompliancePolicyType
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "INTUNE_COMPLIANCE_POLICY_TYPE_ANDROID")]
        INTUNE_COMPLIANCE_POLICY_TYPE_ANDROID,

        [EnumMember(Value = "INTUNE_COMPLIANCE_POLICY_TYPE_ANDROID_AOSP")]
        INTUNE_COMPLIANCE_POLICY_TYPE_ANDROID_AOSP,

        [EnumMember(Value = "INTUNE_COMPLIANCE_POLICY_TYPE_ANDROID_FOR_WORK")]
        INTUNE_COMPLIANCE_POLICY_TYPE_ANDROID_FOR_WORK,

        [EnumMember(Value = "INTUNE_COMPLIANCE_POLICY_TYPE_ANDROID_WORK_PROFILE")]
        INTUNE_COMPLIANCE_POLICY_TYPE_ANDROID_WORK_PROFILE,

        [EnumMember(Value = "INTUNE_COMPLIANCE_POLICY_TYPE_IOS")]
        INTUNE_COMPLIANCE_POLICY_TYPE_IOS,

        [EnumMember(Value = "INTUNE_COMPLIANCE_POLICY_TYPE_MACOS")]
        INTUNE_COMPLIANCE_POLICY_TYPE_MACOS,

        [EnumMember(Value = "INTUNE_COMPLIANCE_POLICY_TYPE_SETTINGS_CATALOG")]
        INTUNE_COMPLIANCE_POLICY_TYPE_SETTINGS_CATALOG,

        [EnumMember(Value = "INTUNE_COMPLIANCE_POLICY_TYPE_UNKNOWN")]
        INTUNE_COMPLIANCE_POLICY_TYPE_UNKNOWN,

        [EnumMember(Value = "INTUNE_COMPLIANCE_POLICY_TYPE_WINDOWS_10")]
        INTUNE_COMPLIANCE_POLICY_TYPE_WINDOWS_10,

        [EnumMember(Value = "INTUNE_COMPLIANCE_POLICY_TYPE_WINDOWS_10_MOBILE")]
        INTUNE_COMPLIANCE_POLICY_TYPE_WINDOWS_10_MOBILE,

        [EnumMember(Value = "INTUNE_COMPLIANCE_POLICY_TYPE_WINDOWS_8")]
        INTUNE_COMPLIANCE_POLICY_TYPE_WINDOWS_8,

        [EnumMember(Value = "INTUNE_COMPLIANCE_POLICY_TYPE_WINDOWS_8_PHONE")]
        INTUNE_COMPLIANCE_POLICY_TYPE_WINDOWS_8_PHONE


    } // enum IntuneCompliancePolicyType

} // namespace RubrikSecurityCloud.Types