// RemediationTargetTypeEnum.cs
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
    public enum RemediationTargetTypeEnum
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "REMEDIATION_TARGET_TYPE_ACTIVITY_EVENT")]
        REMEDIATION_TARGET_TYPE_ACTIVITY_EVENT,

        [EnumMember(Value = "REMEDIATION_TARGET_TYPE_DOCUMENT")]
        REMEDIATION_TARGET_TYPE_DOCUMENT,

        [EnumMember(Value = "REMEDIATION_TARGET_TYPE_PERMISSION")]
        REMEDIATION_TARGET_TYPE_PERMISSION,

        [EnumMember(Value = "REMEDIATION_TARGET_TYPE_UNSPECIFIED")]
        REMEDIATION_TARGET_TYPE_UNSPECIFIED,

        [EnumMember(Value = "REMEDIATION_TARGET_TYPE_VIOLATION")]
        REMEDIATION_TARGET_TYPE_VIOLATION


    } // enum RemediationTargetTypeEnum

} // namespace RubrikSecurityCloud.Types