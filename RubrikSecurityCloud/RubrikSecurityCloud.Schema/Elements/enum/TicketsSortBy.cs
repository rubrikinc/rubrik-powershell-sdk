// TicketsSortBy.cs
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
    public enum TicketsSortBy
    {
        [EnumMember(Value = "LIST_TICKET_SORT_BY_CREATED_ON")]
        LIST_TICKET_SORT_BY_CREATED_ON,

        [EnumMember(Value = "LIST_TICKET_SORT_BY_CREATOR")]
        LIST_TICKET_SORT_BY_CREATOR,

        [EnumMember(Value = "LIST_TICKET_SORT_BY_ID")]
        LIST_TICKET_SORT_BY_ID,

        [EnumMember(Value = "LIST_TICKET_SORT_BY_NAME")]
        LIST_TICKET_SORT_BY_NAME,

        [EnumMember(Value = "LIST_TICKET_SORT_BY_STATUS")]
        LIST_TICKET_SORT_BY_STATUS,

        [EnumMember(Value = "LIST_TICKET_SORT_BY_UNSPECIFIED")]
        LIST_TICKET_SORT_BY_UNSPECIFIED,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN


    } // enum TicketsSortBy

} // namespace RubrikSecurityCloud.Types