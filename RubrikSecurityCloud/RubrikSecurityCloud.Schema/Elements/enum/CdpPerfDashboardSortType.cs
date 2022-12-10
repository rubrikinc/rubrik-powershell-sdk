// CdpPerfDashboardSortType.cs
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
    public enum CdpPerfDashboardSortType
    {
        [EnumMember(Value = "CDP_IO_FILTER_STATUS")]
        CDP_IO_FILTER_STATUS,

        [EnumMember(Value = "LATEST_SNAPSHOT_TIME")]
        LATEST_SNAPSHOT_TIME,

        [EnumMember(Value = "LOCAL_STATUS")]
        LOCAL_STATUS,

        [EnumMember(Value = "REPLICATION_STATUS")]
        REPLICATION_STATUS,

        [EnumMember(Value = "REPLICATION_TARGET")]
        REPLICATION_TARGET,

        [EnumMember(Value = "SLA_DOMAIN")]
        SLA_DOMAIN,

        [EnumMember(Value = "SOURCE_CLUSTER")]
        SOURCE_CLUSTER,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "VM_LOCATION")]
        VM_LOCATION,

        [EnumMember(Value = "VM_NAME")]
        VM_NAME


    } // enum CdpPerfDashboardSortType

} // namespace Rubrik.SecurityCloud.Types