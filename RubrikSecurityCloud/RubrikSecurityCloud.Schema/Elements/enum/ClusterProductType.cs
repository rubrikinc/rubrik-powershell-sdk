// ClusterProductType.cs
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
    public enum ClusterProductType
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "CDM")]
        CDM,

        [EnumMember(Value = "RSCP")]
        RSCP,

        [EnumMember(Value = "UNSPECIFIED")]
        UNSPECIFIED


    } // enum ClusterProductType

} // namespace RubrikSecurityCloud.Types