// UserStatus.cs
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
    public enum UserStatus
    {
        [EnumMember(Value = "ACTIVE")]
        ACTIVE,

        [EnumMember(Value = "DEACTIVATED")]
        DEACTIVATED,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN


    } // enum UserStatus

} // namespace RubrikSecurityCloud.Types