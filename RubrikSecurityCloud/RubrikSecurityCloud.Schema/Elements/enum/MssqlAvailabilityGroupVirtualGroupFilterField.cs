// MssqlAvailabilityGroupVirtualGroupFilterField.cs
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
    public enum MssqlAvailabilityGroupVirtualGroupFilterField
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "CLUSTER_UUID")]
        CLUSTER_UUID,

        [EnumMember(Value = "EFFECTIVE_SLA_WITH_RETENTION_SLA")]
        EFFECTIVE_SLA_WITH_RETENTION_SLA,

        [EnumMember(Value = "FIELD_UNSPECIFIED")]
        FIELD_UNSPECIFIED,

        [EnumMember(Value = "IS_RELIC")]
        IS_RELIC,

        [EnumMember(Value = "IS_REPLICATED")]
        IS_REPLICATED,

        [EnumMember(Value = "NAME")]
        NAME,

        [EnumMember(Value = "ORG_ID")]
        ORG_ID


    } // enum MssqlAvailabilityGroupVirtualGroupFilterField

} // namespace RubrikSecurityCloud.Types