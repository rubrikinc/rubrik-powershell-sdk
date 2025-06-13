// M365ObjectType.cs
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
    public enum M365ObjectType
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "M365_FILE")]
        M365_FILE,

        [EnumMember(Value = "M365_FOLDER")]
        M365_FOLDER,

        [EnumMember(Value = "M365_MAILBOX")]
        M365_MAILBOX,

        [EnumMember(Value = "M365_MAILBOX_FOLDER")]
        M365_MAILBOX_FOLDER,

        [EnumMember(Value = "M365_ONEDRIVE")]
        M365_ONEDRIVE,

        [EnumMember(Value = "M365_SHAREPOINT_DRIVE")]
        M365_SHAREPOINT_DRIVE,

        [EnumMember(Value = "M365_SHAREPOINT_SITE")]
        M365_SHAREPOINT_SITE,

        [EnumMember(Value = "UNSPECIFIED")]
        UNSPECIFIED


    } // enum M365ObjectType

} // namespace RubrikSecurityCloud.Types