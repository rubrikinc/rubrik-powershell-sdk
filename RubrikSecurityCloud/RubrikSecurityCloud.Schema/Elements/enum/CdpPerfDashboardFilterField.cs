// CdpPerfDashboardFilterField.cs
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
    public enum CdpPerfDashboardFilterField
    {
        [EnumMember(Value = "CDP_IO_FILTER_STATUS")]
        CDP_IO_FILTER_STATUS,

        [EnumMember(Value = "LOCAL_STATUS")]
        LOCAL_STATUS,

        [EnumMember(Value = "REPLICATION_STATUS")]
        REPLICATION_STATUS,

        [EnumMember(Value = "SLA_DOMAIN_ID")]
        SLA_DOMAIN_ID,

        [EnumMember(Value = "SOURCE_CLUSTER_UUID")]
        SOURCE_CLUSTER_UUID,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "VM_NAME")]
        VM_NAME


    } // enum CdpPerfDashboardFilterField

} // namespace RubrikSecurityCloud.Types