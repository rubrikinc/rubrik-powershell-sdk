// ConfiguredSlaType.cs
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
    public enum ConfiguredSlaType
    {
        [EnumMember(Value = "CONFIGURED_SLA_TYPE_PROTECTION_SLA")]
        CONFIGURED_SLA_TYPE_PROTECTION_SLA,

        [EnumMember(Value = "CONFIGURED_SLA_TYPE_RETENTION_SLA")]
        CONFIGURED_SLA_TYPE_RETENTION_SLA


    } // enum ConfiguredSlaType

} // namespace RubrikSecurityCloud.Types