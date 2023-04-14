// SnapshotTypeEnum.cs
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
    public enum SnapshotTypeEnum
    {
        [EnumMember(Value = "DOWNLOADED")]
        DOWNLOADED,

        [EnumMember(Value = "ON_DEMAND")]
        ON_DEMAND,

        [EnumMember(Value = "SCHEDULED")]
        SCHEDULED


    } // enum SnapshotTypeEnum

} // namespace Rubrik.SecurityCloud.Types