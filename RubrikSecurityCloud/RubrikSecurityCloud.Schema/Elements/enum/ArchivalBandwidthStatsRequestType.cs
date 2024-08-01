// ArchivalBandwidthStatsRequestType.cs
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
    public enum ArchivalBandwidthStatsRequestType
    {
        [EnumMember(Value = "INTERNAL_ARCHIVAL_BANDWIDTH_REQUEST_BANDWIDTH_TYPE_ALL")]
        INTERNAL_ARCHIVAL_BANDWIDTH_REQUEST_BANDWIDTH_TYPE_ALL,

        [EnumMember(Value = "INTERNAL_ARCHIVAL_BANDWIDTH_REQUEST_BANDWIDTH_TYPE_INCOMING")]
        INTERNAL_ARCHIVAL_BANDWIDTH_REQUEST_BANDWIDTH_TYPE_INCOMING,

        [EnumMember(Value = "INTERNAL_ARCHIVAL_BANDWIDTH_REQUEST_BANDWIDTH_TYPE_OUTGOING")]
        INTERNAL_ARCHIVAL_BANDWIDTH_REQUEST_BANDWIDTH_TYPE_OUTGOING,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN


    } // enum ArchivalBandwidthStatsRequestType

} // namespace RubrikSecurityCloud.Types