// NasVendorType.cs
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
    public enum NasVendorType
    {
        [EnumMember(Value = "NAS_VENDOR_TYPE_FLASHBLADE")]
        NAS_VENDOR_TYPE_FLASHBLADE,

        [EnumMember(Value = "NAS_VENDOR_TYPE_GENERIC")]
        NAS_VENDOR_TYPE_GENERIC,

        [EnumMember(Value = "NAS_VENDOR_TYPE_ISILON")]
        NAS_VENDOR_TYPE_ISILON,

        [EnumMember(Value = "NAS_VENDOR_TYPE_NETAPP")]
        NAS_VENDOR_TYPE_NETAPP,

        [EnumMember(Value = "NAS_VENDOR_TYPE_NUTANIX")]
        NAS_VENDOR_TYPE_NUTANIX


    } // enum NasVendorType

} // namespace Rubrik.SecurityCloud.Types