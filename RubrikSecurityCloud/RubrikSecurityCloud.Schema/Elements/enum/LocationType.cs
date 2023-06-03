// LocationType.cs
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
    public enum LocationType
    {
        [EnumMember(Value = "AWS")]
        AWS,

        [EnumMember(Value = "AZURE")]
        AZURE,

        [EnumMember(Value = "CDM")]
        CDM,

        [EnumMember(Value = "GCP")]
        GCP,

        [EnumMember(Value = "UNKNOWN_TYPE")]
        UNKNOWN_TYPE


    } // enum LocationType

} // namespace Rubrik.SecurityCloud.Types