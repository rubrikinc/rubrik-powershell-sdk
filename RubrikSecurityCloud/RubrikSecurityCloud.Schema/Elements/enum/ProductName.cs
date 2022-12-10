// ProductName.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:31.
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
    public enum ProductName
    {
        [EnumMember(Value = "APPFLOWS")]
        APPFLOWS,

        [EnumMember(Value = "CC_ES")]
        CC_ES,

        [EnumMember(Value = "CLOUDNATIVE")]
        CLOUDNATIVE,

        [EnumMember(Value = "GPS")]
        GPS,

        [EnumMember(Value = "KUBERNETES")]
        KUBERNETES,

        [EnumMember(Value = "NOSQL")]
        NOSQL,

        [EnumMember(Value = "O365")]
        O365,

        [EnumMember(Value = "RADAR")]
        RADAR,

        [EnumMember(Value = "RCV")]
        RCV,

        [EnumMember(Value = "RDP")]
        RDP,

        [EnumMember(Value = "SAPHANA")]
        SAPHANA,

        [EnumMember(Value = "SONAR")]
        SONAR,

        [EnumMember(Value = "UNSPECIFIED_NAME")]
        UNSPECIFIED_NAME


    } // enum ProductName

} // namespace Rubrik.SecurityCloud.Types