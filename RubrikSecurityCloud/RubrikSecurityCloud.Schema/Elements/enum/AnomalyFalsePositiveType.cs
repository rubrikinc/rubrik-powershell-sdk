// AnomalyFalsePositiveType.cs
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
    public enum AnomalyFalsePositiveType
    {
        [EnumMember(Value = "APPLICATION_UPDATE")]
        APPLICATION_UPDATE,

        [EnumMember(Value = "FP_TYPE_UNSPECIFIED")]
        FP_TYPE_UNSPECIFIED,

        [EnumMember(Value = "LOG_ROTATION")]
        LOG_ROTATION,

        [EnumMember(Value = "NFA_SCHEDULED_MAINTENANCE")]
        NFA_SCHEDULED_MAINTENANCE,

        [EnumMember(Value = "NFA_UNSCHEDULED_MAINTENANCE")]
        NFA_UNSCHEDULED_MAINTENANCE,

        [EnumMember(Value = "OS_UPDATE")]
        OS_UPDATE,

        [EnumMember(Value = "OTHER")]
        OTHER,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN


    } // enum AnomalyFalsePositiveType

} // namespace RubrikSecurityCloud.Types