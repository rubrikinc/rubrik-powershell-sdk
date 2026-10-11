// ClusterNotificationType.cs
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
    public enum ClusterNotificationType
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "SEAGATE_ST24000NM007H_FIRMWARE_RISK")]
        SEAGATE_ST24000NM007H_FIRMWARE_RISK,

        [EnumMember(Value = "SSD_V2_UPGRADE")]
        SSD_V2_UPGRADE


    } // enum ClusterNotificationType

} // namespace RubrikSecurityCloud.Types