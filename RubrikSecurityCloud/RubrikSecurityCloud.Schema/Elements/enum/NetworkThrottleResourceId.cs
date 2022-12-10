// NetworkThrottleResourceId.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:23.
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
    public enum NetworkThrottleResourceId
    {
        [EnumMember(Value = "NETWORK_THROTTLE_RESOURCE_ID_ARCHIVAL_EGRESS")]
        NETWORK_THROTTLE_RESOURCE_ID_ARCHIVAL_EGRESS,

        [EnumMember(Value = "NETWORK_THROTTLE_RESOURCE_ID_REPLICATION_EGRESS")]
        NETWORK_THROTTLE_RESOURCE_ID_REPLICATION_EGRESS


    } // enum NetworkThrottleResourceId

} // namespace Rubrik.SecurityCloud.Types