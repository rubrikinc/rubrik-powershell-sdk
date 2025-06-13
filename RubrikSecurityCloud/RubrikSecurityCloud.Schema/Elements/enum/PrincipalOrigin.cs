// PrincipalOrigin.cs
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
    public enum PrincipalOrigin
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "ORIGIN_EXTERNAL")]
        ORIGIN_EXTERNAL,

        [EnumMember(Value = "ORIGIN_INTERNAL")]
        ORIGIN_INTERNAL,

        [EnumMember(Value = "ORIGIN_UNSPECIFIED")]
        ORIGIN_UNSPECIFIED


    } // enum PrincipalOrigin

} // namespace RubrikSecurityCloud.Types