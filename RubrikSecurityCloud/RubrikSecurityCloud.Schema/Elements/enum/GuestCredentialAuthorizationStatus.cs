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

namespace Rubrik.SecurityCloud.Types
{
    public enum GuestCredentialAuthorizationStatus
    {
        [EnumMember(Value = "FAILED")]
        FAILED,

        [EnumMember(Value = "PENDING")]
        PENDING,

        [EnumMember(Value = "SUCCESSFUL")]
        SUCCESSFUL


    } // enum GuestCredentialAuthorizationStatus

} // namespace Rubrik.SecurityCloud.Types