// ReleaseNoteTypeType.cs
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
    public enum ReleaseNoteTypeType
    {
        [EnumMember(Value = "FIX")]
        FIX,

        [EnumMember(Value = "NEW_FEATURE")]
        NEW_FEATURE,

        [EnumMember(Value = "PRODUCT_CHANGE")]
        PRODUCT_CHANGE,

        [EnumMember(Value = "RELEASE_NOTE_TYPE_UNSPECIFIED")]
        RELEASE_NOTE_TYPE_UNSPECIFIED,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN


    } // enum ReleaseNoteTypeType

} // namespace RubrikSecurityCloud.Types