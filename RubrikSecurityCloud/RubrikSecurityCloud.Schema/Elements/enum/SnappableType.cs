// SnappableType.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:51.
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
    public enum SnappableType
    {
        [EnumMember(Value = "CALENDAR")]
        CALENDAR,

        [EnumMember(Value = "CONTACTS")]
        CONTACTS,

        [EnumMember(Value = "EXCHANGE")]
        EXCHANGE,

        [EnumMember(Value = "MAILBOX")]
        MAILBOX,

        [EnumMember(Value = "ONEDRIVE")]
        ONEDRIVE,

        [EnumMember(Value = "SHAREPOINT_DRIVE")]
        SHAREPOINT_DRIVE,

        [EnumMember(Value = "SHAREPOINT_LIST")]
        SHAREPOINT_LIST,

        [EnumMember(Value = "SHAREPOINT_SITE")]
        SHAREPOINT_SITE,

        [EnumMember(Value = "TEAMS")]
        TEAMS


    } // enum SnappableType

} // namespace Rubrik.SecurityCloud.Types