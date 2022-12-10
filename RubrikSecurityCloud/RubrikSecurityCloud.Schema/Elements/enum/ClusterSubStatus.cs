// ClusterSubStatus.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:01.
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
    public enum ClusterSubStatus
    {
        [EnumMember(Value = "DEFAULT")]
        DEFAULT,

        [EnumMember(Value = "INITIALIZING_EVENTS")]
        INITIALIZING_EVENTS,

        [EnumMember(Value = "INITIALIZING_METADATA")]
        INITIALIZING_METADATA,

        [EnumMember(Value = "INITIALIZING_REPORTS")]
        INITIALIZING_REPORTS


    } // enum ClusterSubStatus

} // namespace Rubrik.SecurityCloud.Types