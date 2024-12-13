// LdapLockReason.cs
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
    public enum LdapLockReason
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "ADMINISTRATIVE_LOCK")]
        ADMINISTRATIVE_LOCK,

        [EnumMember(Value = "LOCK_REASON_UNSPECIFIED")]
        LOCK_REASON_UNSPECIFIED


    } // enum LdapLockReason

} // namespace RubrikSecurityCloud.Types