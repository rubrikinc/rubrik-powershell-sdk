// HostRbsStatus.cs
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
    public enum HostRbsStatus
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "HOST_RBS_STATUS_DISCONNECTED")]
        HOST_RBS_STATUS_DISCONNECTED,

        [EnumMember(Value = "HOST_RBS_STATUS_INSTALLED")]
        HOST_RBS_STATUS_INSTALLED,

        [EnumMember(Value = "HOST_RBS_STATUS_NOT_INSTALLED")]
        HOST_RBS_STATUS_NOT_INSTALLED


    } // enum HostRbsStatus

} // namespace RubrikSecurityCloud.Types