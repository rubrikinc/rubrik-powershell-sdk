// SnapshotLocationView.cs
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
    public enum SnapshotLocationView
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "EXCLUDE_EXPIRED")]
        EXCLUDE_EXPIRED,

        [EnumMember(Value = "EXCLUDE_EXPIRED_AND_TO_EXPIRE")]
        EXCLUDE_EXPIRED_AND_TO_EXPIRE,

        [EnumMember(Value = "INCLUDE_EXPIRED")]
        INCLUDE_EXPIRED


    } // enum SnapshotLocationView

} // namespace RubrikSecurityCloud.Types