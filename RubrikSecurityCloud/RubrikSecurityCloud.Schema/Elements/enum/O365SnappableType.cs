// O365SnappableType.cs
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
    public enum O365SnappableType
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "O365_EXCHANGE")]
        O365_EXCHANGE,

        [EnumMember(Value = "O365_ONEDRIVE")]
        O365_ONEDRIVE,

        [EnumMember(Value = "O365_SHAREPOINT")]
        O365_SHAREPOINT,

        [EnumMember(Value = "O365_TEAMS")]
        O365_TEAMS,

        [EnumMember(Value = "O365_UNSPECIFIED")]
        O365_UNSPECIFIED


    } // enum O365SnappableType

} // namespace RubrikSecurityCloud.Types