// ClusterCyberEventLockdownMode.cs
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
    public enum ClusterCyberEventLockdownMode
    {
        [EnumMember(Value = "CYBER_EVENT_LOCKDOWN_MODE_UNSPECIFIED")]
        CYBER_EVENT_LOCKDOWN_MODE_UNSPECIFIED,

        [EnumMember(Value = "ENABLED")]
        ENABLED,

        [EnumMember(Value = "NOT_ENABLED")]
        NOT_ENABLED


    } // enum ClusterCyberEventLockdownMode

} // namespace RubrikSecurityCloud.Types