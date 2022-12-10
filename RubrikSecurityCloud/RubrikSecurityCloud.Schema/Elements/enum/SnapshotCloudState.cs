// SnapshotCloudState.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:07.
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
    public enum SnapshotCloudState
    {
        [EnumMember(Value = "DOWNLOADED_FROM_CLOUD")]
        DOWNLOADED_FROM_CLOUD,

        [EnumMember(Value = "LATEST_ON_CLOUD")]
        LATEST_ON_CLOUD,

        [EnumMember(Value = "LOCAL")]
        LOCAL,

        [EnumMember(Value = "LOCAL_AND_ON_CLOUD")]
        LOCAL_AND_ON_CLOUD,

        [EnumMember(Value = "ON_CLOUD")]
        ON_CLOUD


    } // enum SnapshotCloudState

} // namespace Rubrik.SecurityCloud.Types