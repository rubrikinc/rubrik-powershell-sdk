// SmbAuthenticationStatus.cs
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
    public enum SmbAuthenticationStatus
    {
        [EnumMember(Value = "CONFIGURED")]
        CONFIGURED,

        [EnumMember(Value = "FAILED")]
        FAILED,

        [EnumMember(Value = "NOT_CONFIGURED")]
        NOT_CONFIGURED,

        [EnumMember(Value = "UNSPECIFIED")]
        UNSPECIFIED


    } // enum SmbAuthenticationStatus

} // namespace Rubrik.SecurityCloud.Types