// Db2SnapshotType.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:05.
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
    public enum Db2SnapshotType
    {
        [EnumMember(Value = "DIFFERENTIAL")]
        DIFFERENTIAL,

        [EnumMember(Value = "FULL")]
        FULL,

        [EnumMember(Value = "INCREMENTAL")]
        INCREMENTAL


    } // enum Db2SnapshotType

} // namespace Rubrik.SecurityCloud.Types