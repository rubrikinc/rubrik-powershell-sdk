// GcpInstanceType.cs
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
    public enum GcpInstanceType
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "GCP_TYPE_UNSPECIFIED")]
        GCP_TYPE_UNSPECIFIED,

        [EnumMember(Value = "N2D_HIGHMEM_16")]
        N2D_HIGHMEM_16,

        [EnumMember(Value = "N2D_STANDARD_16")]
        N2D_STANDARD_16,

        [EnumMember(Value = "N2D_STANDARD_8")]
        N2D_STANDARD_8,

        [EnumMember(Value = "N2_HIGHMEM_16")]
        N2_HIGHMEM_16,

        [EnumMember(Value = "N2_STANDARD_16")]
        N2_STANDARD_16,

        [EnumMember(Value = "N2_STANDARD_8")]
        N2_STANDARD_8


    } // enum GcpInstanceType

} // namespace RubrikSecurityCloud.Types