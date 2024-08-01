// EntitlementStatus.cs
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
    public enum EntitlementStatus
    {
        [EnumMember(Value = "ES_ACTIVE")]
        ES_ACTIVE,

        [EnumMember(Value = "ES_EXPIRED")]
        ES_EXPIRED,

        [EnumMember(Value = "ES_INACTIVE")]
        ES_INACTIVE,

        [EnumMember(Value = "ES_UNSPECIFIED")]
        ES_UNSPECIFIED,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN


    } // enum EntitlementStatus

} // namespace RubrikSecurityCloud.Types