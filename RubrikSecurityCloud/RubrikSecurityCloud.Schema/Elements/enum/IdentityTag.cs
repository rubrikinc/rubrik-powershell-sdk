// IdentityTag.cs
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
    public enum IdentityTag
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "AT_RISK")]
        AT_RISK,

        [EnumMember(Value = "IDENTITY_TAG_UNSPECIFIED")]
        IDENTITY_TAG_UNSPECIFIED,

        [EnumMember(Value = "PRIVILEGED")]
        PRIVILEGED,

        [EnumMember(Value = "SENSITIVE")]
        SENSITIVE


    } // enum IdentityTag

} // namespace RubrikSecurityCloud.Types