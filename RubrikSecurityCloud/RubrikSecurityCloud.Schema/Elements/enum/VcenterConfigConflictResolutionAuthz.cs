// VcenterConfigConflictResolutionAuthz.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:04:41.
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
    public enum VcenterConfigConflictResolutionAuthz
    {
        [EnumMember(Value = "VCENTER_CONFIG_CONFLICT_RESOLUTION_AUTHZ_ALLOW_AUTO_CONFLICT_RESOLUTION")]
        VCENTER_CONFIG_CONFLICT_RESOLUTION_AUTHZ_ALLOW_AUTO_CONFLICT_RESOLUTION,

        [EnumMember(Value = "VCENTER_CONFIG_CONFLICT_RESOLUTION_AUTHZ_NO_CONFLICT_RESOLUTION")]
        VCENTER_CONFIG_CONFLICT_RESOLUTION_AUTHZ_NO_CONFLICT_RESOLUTION


    } // enum VcenterConfigConflictResolutionAuthz

} // namespace Rubrik.SecurityCloud.Types