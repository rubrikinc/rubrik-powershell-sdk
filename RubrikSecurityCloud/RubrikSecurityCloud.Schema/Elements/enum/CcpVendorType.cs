// CcpVendorType.cs
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
    public enum CcpVendorType
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "AWS")]
        AWS,

        [EnumMember(Value = "AZURE")]
        AZURE,

        [EnumMember(Value = "GCP")]
        GCP,

        [EnumMember(Value = "VENDOR_UNKNOWN")]
        VENDOR_UNKNOWN


    } // enum CcpVendorType

} // namespace RubrikSecurityCloud.Types