// LockMethod.cs
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
    public enum LockMethod
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "ADMINISTRATIVE_LOCK")]
        ADMINISTRATIVE_LOCK,

        [EnumMember(Value = "BRUTE_FORCE")]
        BRUTE_FORCE,

        [EnumMember(Value = "INACTIVITY")]
        INACTIVITY,

        [EnumMember(Value = "LEAKED_PASSWORD")]
        LEAKED_PASSWORD,

        [EnumMember(Value = "LOCK_METHOD_UNSPECIFIED")]
        LOCK_METHOD_UNSPECIFIED


    } // enum LockMethod

} // namespace RubrikSecurityCloud.Types