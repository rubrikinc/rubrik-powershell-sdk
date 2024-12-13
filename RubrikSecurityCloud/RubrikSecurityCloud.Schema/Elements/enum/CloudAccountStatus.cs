// CloudAccountStatus.cs
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
    public enum CloudAccountStatus
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "CONNECTED")]
        CONNECTED,

        [EnumMember(Value = "CONNECTING")]
        CONNECTING,

        [EnumMember(Value = "DISABLED")]
        DISABLED,

        [EnumMember(Value = "DISCONNECTED")]
        DISCONNECTED,

        [EnumMember(Value = "MISSING_PERMISSIONS")]
        MISSING_PERMISSIONS


    } // enum CloudAccountStatus

} // namespace RubrikSecurityCloud.Types