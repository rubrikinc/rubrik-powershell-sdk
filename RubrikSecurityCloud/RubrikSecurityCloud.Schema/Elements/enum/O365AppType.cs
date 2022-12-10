// O365AppType.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:04:32.
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
    public enum O365AppType
    {
        [EnumMember(Value = "AADSAAS")]
        AADSAAS,

        [EnumMember(Value = "APP_TYPE_UNSPECIFIED")]
        APP_TYPE_UNSPECIFIED,

        [EnumMember(Value = "AZURE")]
        AZURE,

        [EnumMember(Value = "AZUREGOV")]
        AZUREGOV,

        [EnumMember(Value = "EXCHANGE")]
        EXCHANGE,

        [EnumMember(Value = "M365MGMT")]
        M365_MGMT,

        [EnumMember(Value = "ONEDRIVE")]
        ONEDRIVE,

        [EnumMember(Value = "SPOINT")]
        SPOINT,

        [EnumMember(Value = "TEAMS")]
        TEAMS


    } // enum O365AppType

} // namespace Rubrik.SecurityCloud.Types