// MfaStatus.cs
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
    public enum MfaStatus
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "ENFORCED_BY_GLOBAL")]
        ENFORCED_BY_GLOBAL,

        [EnumMember(Value = "ENFORCED_BY_TENANT")]
        ENFORCED_BY_TENANT,

        [EnumMember(Value = "MFA_STATUS_UNKNOWN")]
        MFA_STATUS_UNKNOWN,

        [EnumMember(Value = "NOT_ENFORCED")]
        NOT_ENFORCED


    } // enum MfaStatus

} // namespace RubrikSecurityCloud.Types