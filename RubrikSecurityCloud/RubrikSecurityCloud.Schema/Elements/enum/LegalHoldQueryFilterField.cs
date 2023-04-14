// LegalHoldQueryFilterField.cs
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
    public enum LegalHoldQueryFilterField
    {
        [EnumMember(Value = "LEGAL_HOLD_TIME")]
        LEGAL_HOLD_TIME,

        [EnumMember(Value = "SNAPPABLE_NAME")]
        SNAPPABLE_NAME,

        [EnumMember(Value = "SNAPPABLE_TYPE")]
        SNAPPABLE_TYPE,

        [EnumMember(Value = "SNAPSHOT_CUSTOMIZATION")]
        SNAPSHOT_CUSTOMIZATION,

        [EnumMember(Value = "SNAPSHOT_TAKEN_TIME")]
        SNAPSHOT_TAKEN_TIME,

        [EnumMember(Value = "SNAPSHOT_TYPE")]
        SNAPSHOT_TYPE,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN


    } // enum LegalHoldQueryFilterField

} // namespace Rubrik.SecurityCloud.Types