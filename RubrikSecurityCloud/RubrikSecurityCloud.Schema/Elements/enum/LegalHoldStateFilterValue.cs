// LegalHoldStateFilterValue.cs
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
    public enum LegalHoldStateFilterValue
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "EXISTING_SNAPSHOTS")]
        EXISTING_SNAPSHOTS,

        [EnumMember(Value = "FUTURE_SNAPSHOTS")]
        FUTURE_SNAPSHOTS,

        [EnumMember(Value = "NO_LEGAL_HOLD")]
        NO_LEGAL_HOLD


    } // enum LegalHoldStateFilterValue

} // namespace RubrikSecurityCloud.Types