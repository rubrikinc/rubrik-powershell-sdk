// O365AppType.cs
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
    public enum O365AppType
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "AADSAAS")]
        AADSAAS,

        [EnumMember(Value = "APP_TYPE_UNSPECIFIED")]
        APP_TYPE_UNSPECIFIED,

        [EnumMember(Value = "AZURE")]
        AZURE,

        [EnumMember(Value = "AZUREGOV")]
        AZUREGOV,

        [EnumMember(Value = "BYOK_GOV")]
        BYOK_GOV,

        [EnumMember(Value = "EXCHANGE")]
        EXCHANGE,

        [EnumMember(Value = "M365MGMT")]
        M365_MGMT,

        [EnumMember(Value = "ONEDRIVE")]
        ONEDRIVE,

        [EnumMember(Value = "PURVIEW")]
        PURVIEW,

        [EnumMember(Value = "SPOINT")]
        SPOINT,

        [EnumMember(Value = "TEAMS")]
        TEAMS


    } // enum O365AppType

} // namespace RubrikSecurityCloud.Types