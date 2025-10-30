// ThreatMonitoringEnablementEntity.cs
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
    public enum ThreatMonitoringEnablementEntity
    {
        [EnumMember(Value = "CDM_CLUSTER")]
        CDM_CLUSTER,

        [EnumMember(Value = "CLOUD_DIRECT_CLUSTER")]
        CLOUD_DIRECT_CLUSTER,

        [EnumMember(Value = "CLOUD_NATIVE_ROOT")]
        CLOUD_NATIVE_ROOT,

        [EnumMember(Value = "MICROSOFT_365")]
        MICROSOFT_365,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN


    } // enum ThreatMonitoringEnablementEntity

} // namespace RubrikSecurityCloud.Types