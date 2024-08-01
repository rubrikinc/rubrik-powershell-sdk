// TicketStatusSyncInfo.cs
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
    public enum TicketStatusSyncInfo
    {
        [EnumMember(Value = "TICKET_STATUS_IN_SYNC")]
        TICKET_STATUS_IN_SYNC,

        [EnumMember(Value = "TICKET_STATUS_OUT_OF_SYNC_INTERNAL")]
        TICKET_STATUS_OUT_OF_SYNC_INTERNAL,

        [EnumMember(Value = "TICKET_STATUS_SYNC_UNSPECIFIED")]
        TICKET_STATUS_SYNC_UNSPECIFIED,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN


    } // enum TicketStatusSyncInfo

} // namespace RubrikSecurityCloud.Types