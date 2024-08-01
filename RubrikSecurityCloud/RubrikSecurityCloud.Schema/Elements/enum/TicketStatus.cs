// TicketStatus.cs
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
    public enum TicketStatus
    {
        [EnumMember(Value = "CLOSED")]
        CLOSED,

        [EnumMember(Value = "CREATION_FAILED")]
        CREATION_FAILED,

        [EnumMember(Value = "CREATION_IN_PROGRESS")]
        CREATION_IN_PROGRESS,

        [EnumMember(Value = "OPEN")]
        OPEN,

        [EnumMember(Value = "TICKET_STATUS_UNSPECIFIED")]
        TICKET_STATUS_UNSPECIFIED,

        [EnumMember(Value = "TO_BE_CREATED")]
        TO_BE_CREATED,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN


    } // enum TicketStatus

} // namespace RubrikSecurityCloud.Types