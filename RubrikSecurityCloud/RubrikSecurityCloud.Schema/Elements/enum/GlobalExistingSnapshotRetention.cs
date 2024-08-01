// GlobalExistingSnapshotRetention.cs
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
    public enum GlobalExistingSnapshotRetention
    {
        [EnumMember(Value = "EXPIRE_IMMEDIATELY")]
        EXPIRE_IMMEDIATELY,

        [EnumMember(Value = "KEEP_FOREVER")]
        KEEP_FOREVER,

        [EnumMember(Value = "NOT_APPLICABLE")]
        NOT_APPLICABLE,

        [EnumMember(Value = "RETAIN_SNAPSHOTS")]
        RETAIN_SNAPSHOTS,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN


    } // enum GlobalExistingSnapshotRetention

} // namespace RubrikSecurityCloud.Types