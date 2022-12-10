// Product.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:04.
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
    public enum Product
    {
        [EnumMember(Value = "CLOUD")]
        CLOUD,

        [EnumMember(Value = "E1000")]
        E1000,

        [EnumMember(Value = "EDGE")]
        EDGE,

        [EnumMember(Value = "FREE_RSC")]
        FREE_RSC,

        [EnumMember(Value = "PRODUCT_UNKNOWN")]
        PRODUCT_UNKNOWN,

        [EnumMember(Value = "RUBRIK_APPLIANCE")]
        RUBRIK_APPLIANCE,

        [EnumMember(Value = "RVC")]
        RVC,

        [EnumMember(Value = "SCALE")]
        SCALE,

        [EnumMember(Value = "THIRDPARTY_HARDWARE")]
        THIRDPARTY_HARDWARE


    } // enum Product

} // namespace Rubrik.SecurityCloud.Types