// ConfiguredSlaType.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:37.
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
    public enum ConfiguredSlaType
    {
        [EnumMember(Value = "CONFIGURED_SLA_TYPE_PROTECTION_SLA")]
        CONFIGURED_SLA_TYPE_PROTECTION_SLA,

        [EnumMember(Value = "CONFIGURED_SLA_TYPE_RETENTION_SLA")]
        CONFIGURED_SLA_TYPE_RETENTION_SLA


    } // enum ConfiguredSlaType

} // namespace Rubrik.SecurityCloud.Types