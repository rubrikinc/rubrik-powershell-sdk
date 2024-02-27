// LdapUnlockReason.cs
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
    public enum LdapUnlockReason
    {
        [EnumMember(Value = "ADMINISTRATIVE_UNLOCK")]
        ADMINISTRATIVE_UNLOCK,

        [EnumMember(Value = "UNLOCK_REASON_UNSPECIFIED")]
        UNLOCK_REASON_UNSPECIFIED


    } // enum LdapUnlockReason

} // namespace RubrikSecurityCloud.Types