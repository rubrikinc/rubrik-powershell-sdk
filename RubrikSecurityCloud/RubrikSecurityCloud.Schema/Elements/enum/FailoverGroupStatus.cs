// FailoverGroupStatus.cs
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
    public enum FailoverGroupStatus
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "FAILOVER_GROUP_STATUS_ERROR")]
        FAILOVER_GROUP_STATUS_ERROR,

        [EnumMember(Value = "FAILOVER_GROUP_STATUS_FAILOVER_IN_PROGRESS")]
        FAILOVER_GROUP_STATUS_FAILOVER_IN_PROGRESS,

        [EnumMember(Value = "FAILOVER_GROUP_STATUS_OK")]
        FAILOVER_GROUP_STATUS_OK,

        [EnumMember(Value = "FAILOVER_GROUP_STATUS_UNSPECIFIED")]
        FAILOVER_GROUP_STATUS_UNSPECIFIED,

        [EnumMember(Value = "FAILOVER_GROUP_STATUS_WARNING")]
        FAILOVER_GROUP_STATUS_WARNING


    } // enum FailoverGroupStatus

} // namespace RubrikSecurityCloud.Types