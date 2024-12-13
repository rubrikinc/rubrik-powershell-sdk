// Encryption.cs
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
    public enum Encryption
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "ENCRYPTION_DISABLED")]
        ENCRYPTION_DISABLED,

        [EnumMember(Value = "ENCRYPTION_ENABLED")]
        ENCRYPTION_ENABLED,

        [EnumMember(Value = "ENCRYPTION_UNSPECIFIED")]
        ENCRYPTION_UNSPECIFIED


    } // enum Encryption

} // namespace RubrikSecurityCloud.Types