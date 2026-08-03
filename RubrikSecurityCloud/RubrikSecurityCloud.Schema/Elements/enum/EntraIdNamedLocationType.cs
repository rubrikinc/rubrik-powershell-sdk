// EntraIdNamedLocationType.cs
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
    public enum EntraIdNamedLocationType
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "EID_NL_TYPE_COUNTRY")]
        EID_NL_TYPE_COUNTRY,

        [EnumMember(Value = "EID_NL_TYPE_IP")]
        EID_NL_TYPE_IP,

        [EnumMember(Value = "EID_NL_TYPE_UNSPECIFIED")]
        EID_NL_TYPE_UNSPECIFIED


    } // enum EntraIdNamedLocationType

} // namespace RubrikSecurityCloud.Types