// GlobalExistingSnapshotRetention.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:04:26.
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
    public enum GlobalExistingSnapshotRetention
    {
        [EnumMember(Value = "EXPIRE_IMMEDIATELY")]
        EXPIRE_IMMEDIATELY,

        [EnumMember(Value = "KEEP_FOREVER")]
        KEEP_FOREVER,

        [EnumMember(Value = "NOT_APPLICABLE")]
        NOT_APPLICABLE,

        [EnumMember(Value = "RETAIN_SNAPSHOTS")]
        RETAIN_SNAPSHOTS


    } // enum GlobalExistingSnapshotRetention

} // namespace Rubrik.SecurityCloud.Types