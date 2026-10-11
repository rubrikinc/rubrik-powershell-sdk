// ThreatMonitoringMuteStatusFilter.cs
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
    public enum ThreatMonitoringMuteStatusFilter
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "THREAT_MONITORING_MUTE_STATUS_FILTER_ACTIVE")]
        THREAT_MONITORING_MUTE_STATUS_FILTER_ACTIVE,

        [EnumMember(Value = "THREAT_MONITORING_MUTE_STATUS_FILTER_MUTED")]
        THREAT_MONITORING_MUTE_STATUS_FILTER_MUTED,

        [EnumMember(Value = "THREAT_MONITORING_MUTE_STATUS_FILTER_UNSPECIFIED")]
        THREAT_MONITORING_MUTE_STATUS_FILTER_UNSPECIFIED


    } // enum ThreatMonitoringMuteStatusFilter

} // namespace RubrikSecurityCloud.Types