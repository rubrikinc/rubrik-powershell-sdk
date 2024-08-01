// SlaSourceClustersDisableReason.cs
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
    public enum SlaSourceClustersDisableReason
    {
        [EnumMember(Value = "NO_USE_AS_REPLICATION_TARGET_PRIVILEGE")]
        NO_USE_AS_REPLICATION_TARGET_PRIVILEGE,

        [EnumMember(Value = "NO_VIEW_ARCHIVAL_LOCATION_PRIVILEGE")]
        NO_VIEW_ARCHIVAL_LOCATION_PRIVILEGE,

        [EnumMember(Value = "REASON_UNSPECIFIED")]
        REASON_UNSPECIFIED,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN


    } // enum SlaSourceClustersDisableReason

} // namespace RubrikSecurityCloud.Types