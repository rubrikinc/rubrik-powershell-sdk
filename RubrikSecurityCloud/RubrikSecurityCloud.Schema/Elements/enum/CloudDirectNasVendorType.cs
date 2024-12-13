// CloudDirectNasVendorType.cs
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
    public enum CloudDirectNasVendorType
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "FLASHBLADE")]
        FLASHBLADE,

        [EnumMember(Value = "GENERIC")]
        GENERIC,

        [EnumMember(Value = "ISILON")]
        ISILON,

        [EnumMember(Value = "NETAPP")]
        NETAPP,

        [EnumMember(Value = "NUTANIX")]
        NUTANIX,

        [EnumMember(Value = "NUTANIX_FILESERVER")]
        NUTANIX_FILESERVER,

        [EnumMember(Value = "UNSPECIFIED")]
        UNSPECIFIED


    } // enum CloudDirectNasVendorType

} // namespace RubrikSecurityCloud.Types