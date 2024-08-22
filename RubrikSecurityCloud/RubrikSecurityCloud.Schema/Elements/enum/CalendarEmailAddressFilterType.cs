// CalendarEmailAddressFilterType.cs
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
    public enum CalendarEmailAddressFilterType
    {
        [EnumMember(Value = "ALL")]
        ALL,

        [EnumMember(Value = "ATTENDEE")]
        ATTENDEE,

        [EnumMember(Value = "ORGANIZER")]
        ORGANIZER,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN


    } // enum CalendarEmailAddressFilterType

} // namespace RubrikSecurityCloud.Types