// MaskingTechnique.cs
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
    public enum MaskingTechnique
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "BLANKING")]
        BLANKING,

        [EnumMember(Value = "FORMAT_PRESERVING_SUBSTITUTION")]
        FORMAT_PRESERVING_SUBSTITUTION,

        [EnumMember(Value = "NUMERIC_RANGE")]
        NUMERIC_RANGE,

        [EnumMember(Value = "SHUFFLE")]
        SHUFFLE,

        [EnumMember(Value = "SUBSTITUTION")]
        SUBSTITUTION


    } // enum MaskingTechnique

} // namespace RubrikSecurityCloud.Types