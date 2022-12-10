// CalendarEmailAddressFilterType.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:53.
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
    public enum CalendarEmailAddressFilterType
    {
        [EnumMember(Value = "ALL")]
        ALL,

        [EnumMember(Value = "ATTENDEE")]
        ATTENDEE,

        [EnumMember(Value = "ORGANIZER")]
        ORGANIZER


    } // enum CalendarEmailAddressFilterType

} // namespace Rubrik.SecurityCloud.Types