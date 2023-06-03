// ComponentEnum.cs
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
    public enum ComponentEnum
    {
        [EnumMember(Value = "APP_FLOWS")]
        APP_FLOWS,

        [EnumMember(Value = "AWS_NATIVE")]
        AWS_NATIVE,

        [EnumMember(Value = "AWS_SOURCE")]
        AWS_SOURCE,

        [EnumMember(Value = "AZUREAD")]
        AZUREAD,

        [EnumMember(Value = "AZURE_NATIVE")]
        AZURE_NATIVE,

        [EnumMember(Value = "BLOBSTORE")]
        BLOBSTORE,

        [EnumMember(Value = "CEREBRO")]
        CEREBRO,

        [EnumMember(Value = "CLOUD_ACCOUNTS")]
        CLOUD_ACCOUNTS,

        [EnumMember(Value = "CLOUD_NATIVE")]
        CLOUD_NATIVE,

        [EnumMember(Value = "COLOSSUS")]
        COLOSSUS,

        [EnumMember(Value = "CORE_EXPERIENCE")]
        CORE_EXPERIENCE,

        [EnumMember(Value = "DATA_GOV")]
        DATA_GOV,

        [EnumMember(Value = "DHRC")]
        DHRC,

        [EnumMember(Value = "EXO_COMPUTE")]
        EXO_COMPUTE,

        [EnumMember(Value = "FELDSPAR")]
        FELDSPAR,

        [EnumMember(Value = "FORGE")]
        FORGE,

        [EnumMember(Value = "GCP_NATIVE")]
        GCP_NATIVE,

        [EnumMember(Value = "GPS")]
        GPS,

        [EnumMember(Value = "KUPR")]
        KUPR,

        [EnumMember(Value = "LAMBDA")]
        LAMBDA,

        [EnumMember(Value = "O365")]
        O365,

        [EnumMember(Value = "PLATFORM")]
        PLATFORM,

        [EnumMember(Value = "QUICKSILVER")]
        QUICKSILVER,

        [EnumMember(Value = "RADAR")]
        RADAR,

        [EnumMember(Value = "SAAS_APPS")]
        SAAS_APPS,

        [EnumMember(Value = "SNAPPABLES")]
        SNAPPABLES,

        [EnumMember(Value = "SONAR")]
        SONAR,

        [EnumMember(Value = "THOR")]
        THOR,

        [EnumMember(Value = "THOR_UPLOAD")]
        THOR_UPLOAD,

        [EnumMember(Value = "USER_AWARENESS")]
        USER_AWARENESS,

        [EnumMember(Value = "USER_MANAGEMENT")]
        USER_MANAGEMENT,

        [EnumMember(Value = "WATCHERS")]
        WATCHERS


    } // enum ComponentEnum

} // namespace Rubrik.SecurityCloud.Types