// CreateTicketStatus.cs
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
    public enum CreateTicketStatus
    {
        [EnumMember(Value = "FAILURE_CONFLICTING_UUID")]
        FAILURE_CONFLICTING_UUID,

        [EnumMember(Value = "FAILURE_INVALID_INPUT")]
        FAILURE_INVALID_INPUT,

        [EnumMember(Value = "FAILURE_INVALID_STATUS_TRANSITION")]
        FAILURE_INVALID_STATUS_TRANSITION,

        [EnumMember(Value = "FAILURE_NO_PLATFORM_CONFIGURED")]
        FAILURE_NO_PLATFORM_CONFIGURED,

        [EnumMember(Value = "SUCCESS")]
        SUCCESS,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN


    } // enum CreateTicketStatus

} // namespace RubrikSecurityCloud.Types