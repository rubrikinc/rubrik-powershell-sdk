// TicketingPlatform.cs
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
    public enum TicketingPlatform
    {
        [EnumMember(Value = "SERVICENOW")]
        SERVICENOW,

        [EnumMember(Value = "TICKETING_PLATFORM_UNSPECIFIED")]
        TICKETING_PLATFORM_UNSPECIFIED,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN


    } // enum TicketingPlatform

} // namespace RubrikSecurityCloud.Types