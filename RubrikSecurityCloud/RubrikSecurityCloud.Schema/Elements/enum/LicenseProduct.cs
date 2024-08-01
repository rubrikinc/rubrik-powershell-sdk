// LicenseProduct.cs
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
    public enum LicenseProduct
    {
        [EnumMember(Value = "LP_CCES")]
        LP_CCES,

        [EnumMember(Value = "LP_CLOUD")]
        LP_CLOUD,

        [EnumMember(Value = "LP_CNP")]
        LP_CNP,

        [EnumMember(Value = "LP_O365")]
        LP_O365,

        [EnumMember(Value = "LP_UNKNOWN")]
        LP_UNKNOWN,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN


    } // enum LicenseProduct

} // namespace RubrikSecurityCloud.Types