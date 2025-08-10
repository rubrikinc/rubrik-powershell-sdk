// UserMfaStatus.cs
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
    public enum UserMfaStatus
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "CONFIGURED_ENFORCED")]
        CONFIGURED_ENFORCED,

        [EnumMember(Value = "CONFIGURED_UNENFORCED")]
        CONFIGURED_UNENFORCED,

        [EnumMember(Value = "NA")]
        NA,

        [EnumMember(Value = "NA_SSO")]
        NA_SSO,

        [EnumMember(Value = "NOT_CONFIGURED_ENFORCED")]
        NOT_CONFIGURED_ENFORCED,

        [EnumMember(Value = "NOT_CONFIGURED_UNENFORCED")]
        NOT_CONFIGURED_UNENFORCED,

        [EnumMember(Value = "UNSPECIFIED")]
        UNSPECIFIED


    } // enum UserMfaStatus

} // namespace RubrikSecurityCloud.Types