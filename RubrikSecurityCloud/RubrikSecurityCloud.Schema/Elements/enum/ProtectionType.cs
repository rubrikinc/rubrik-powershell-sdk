// ProtectionType.cs
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
    public enum ProtectionType
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "BACKUP_STORAGE")]
        BACKUP_STORAGE,

        [EnumMember(Value = "PROTECTION_TYPE_UNSPECIFIED")]
        PROTECTION_TYPE_UNSPECIFIED,

        [EnumMember(Value = "RUBRIK")]
        RUBRIK


    } // enum ProtectionType

} // namespace RubrikSecurityCloud.Types