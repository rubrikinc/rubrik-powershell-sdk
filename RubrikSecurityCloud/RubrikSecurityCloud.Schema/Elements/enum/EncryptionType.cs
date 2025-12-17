// EncryptionType.cs
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
    public enum EncryptionType
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "ENCRYPTION_TYPE_BYOK")]
        ENCRYPTION_TYPE_BYOK,

        [EnumMember(Value = "ENCRYPTION_TYPE_RUBRIK")]
        ENCRYPTION_TYPE_RUBRIK


    } // enum EncryptionType

} // namespace RubrikSecurityCloud.Types