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

namespace RubrikSecurityCloud.Types
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
        UNKNOWN_TYPE,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN


    } // enum LocationType

} // namespace RubrikSecurityCloud.Types