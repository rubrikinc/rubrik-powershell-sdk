// IdpType.cs
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
    public enum IdpType
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "AWS")]
        AWS,

        [EnumMember(Value = "ENTRA_ID")]
        ENTRA_ID,

        [EnumMember(Value = "IDP_UNSPECIFIED")]
        IDP_UNSPECIFIED,

        [EnumMember(Value = "LOCAL_AD")]
        LOCAL_AD,

        [EnumMember(Value = "ON_PREM_AD")]
        ON_PREM_AD,

        [EnumMember(Value = "SHAREPOINT")]
        SHAREPOINT,

        [EnumMember(Value = "SYSTEM")]
        SYSTEM


    } // enum IdpType

} // namespace RubrikSecurityCloud.Types