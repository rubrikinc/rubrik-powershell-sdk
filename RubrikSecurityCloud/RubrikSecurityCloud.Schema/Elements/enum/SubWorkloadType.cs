// SubWorkloadType.cs
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

namespace Rubrik.SecurityCloud.Types
{
    public enum SubWorkloadType
    {
        [EnumMember(Value = "NONE")]
        NONE,

        [EnumMember(Value = "O365_CALENDAR")]
        O365_CALENDAR,

        [EnumMember(Value = "O365_CONTACT")]
        O365_CONTACT,

        [EnumMember(Value = "O365_MAILBOX")]
        O365_MAILBOX


    } // enum SubWorkloadType

} // namespace Rubrik.SecurityCloud.Types