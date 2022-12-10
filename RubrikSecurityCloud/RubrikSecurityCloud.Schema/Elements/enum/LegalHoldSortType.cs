// LegalHoldSortType.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:04:02.
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
    public enum LegalHoldSortType
    {
        [EnumMember(Value = "LEGAL_HOLD_SNAPSHOT_COUNT")]
        LEGAL_HOLD_SNAPSHOT_COUNT,

        [EnumMember(Value = "LEGAL_HOLD_TIME")]
        LEGAL_HOLD_TIME,

        [EnumMember(Value = "SNAPPABLE_NAME")]
        SNAPPABLE_NAME,

        [EnumMember(Value = "SNAPPABLE_TYPE")]
        SNAPPABLE_TYPE,

        [EnumMember(Value = "SNAPSHOT_TIME")]
        SNAPSHOT_TIME,

        [EnumMember(Value = "SNAPSHOT_TYPE")]
        SNAPSHOT_TYPE,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN


    } // enum LegalHoldSortType

} // namespace Rubrik.SecurityCloud.Types