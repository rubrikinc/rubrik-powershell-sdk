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

namespace Rubrik.SecurityCloud.Types
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
        RELEASE_NOTE_TYPE_UNSPECIFIED


    } // enum ReleaseNoteTypeType

} // namespace Rubrik.SecurityCloud.Types