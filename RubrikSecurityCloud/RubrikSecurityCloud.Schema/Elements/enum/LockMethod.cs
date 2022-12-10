// LockMethod.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:02.
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
    public enum LockMethod
    {
        [EnumMember(Value = "ADMINISTRATIVE_LOCK")]
        ADMINISTRATIVE_LOCK,

        [EnumMember(Value = "BRUTE_FORCE")]
        BRUTE_FORCE,

        [EnumMember(Value = "LOCK_METHOD_UNSPECIFIED")]
        LOCK_METHOD_UNSPECIFIED


    } // enum LockMethod

} // namespace Rubrik.SecurityCloud.Types