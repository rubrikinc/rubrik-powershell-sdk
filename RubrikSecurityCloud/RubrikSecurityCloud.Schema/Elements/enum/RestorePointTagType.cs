// RestorePointTagType.cs
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
    public enum RestorePointTagType
    {
        [EnumMember(Value = "FAST")]
        FAST,

        [EnumMember(Value = "RESTORE_POINT_TAG_TYPE_UNSPECIFIED")]
        RESTORE_POINT_TAG_TYPE_UNSPECIFIED,

        [EnumMember(Value = "STANDARD")]
        STANDARD,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN


    } // enum RestorePointTagType

} // namespace RubrikSecurityCloud.Types