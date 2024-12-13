// ClusterEosStatus.cs
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
    public enum ClusterEosStatus
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "EOS_STATUS_PLAN_UPGRADE")]
        EOS_STATUS_PLAN_UPGRADE,

        [EnumMember(Value = "EOS_STATUS_SUPPORTED")]
        EOS_STATUS_SUPPORTED,

        [EnumMember(Value = "EOS_STATUS_UNKNOWN")]
        EOS_STATUS_UNKNOWN,

        [EnumMember(Value = "EOS_STATUS_UNSUPPORTED")]
        EOS_STATUS_UNSUPPORTED


    } // enum ClusterEosStatus

} // namespace RubrikSecurityCloud.Types