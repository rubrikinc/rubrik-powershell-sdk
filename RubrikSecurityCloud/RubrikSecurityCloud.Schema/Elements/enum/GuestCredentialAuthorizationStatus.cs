// GuestCredentialAuthorizationStatus.cs
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
    public enum GuestCredentialAuthorizationStatus
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "FAILED")]
        FAILED,

        [EnumMember(Value = "PENDING")]
        PENDING,

        [EnumMember(Value = "SUCCESSFUL")]
        SUCCESSFUL


    } // enum GuestCredentialAuthorizationStatus

} // namespace RubrikSecurityCloud.Types