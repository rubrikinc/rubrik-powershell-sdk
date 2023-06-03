// InsecureReason.cs
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
    public enum InsecureReason
    {
        [EnumMember(Value = "NO_PASSWORD_POLICY")]
        NO_PASSWORD_POLICY,

        [EnumMember(Value = "PASSWORD_NEVER_EXPIRES")]
        PASSWORD_NEVER_EXPIRES,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN


    } // enum InsecureReason

} // namespace Rubrik.SecurityCloud.Types