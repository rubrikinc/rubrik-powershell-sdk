// RetentionLockMode.cs
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
    public enum RetentionLockMode
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "COMPLIANCE")]
        COMPLIANCE,

        [EnumMember(Value = "GOVERNANCE")]
        GOVERNANCE,

        [EnumMember(Value = "NO_MODE")]
        NO_MODE


    } // enum RetentionLockMode

} // namespace RubrikSecurityCloud.Types