// ProductType.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:31.
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
    public enum ProductType
    {
        [EnumMember(Value = "POC")]
        POC,

        [EnumMember(Value = "REVENUE")]
        REVENUE,

        [EnumMember(Value = "TRIAL")]
        TRIAL,

        [EnumMember(Value = "UNSPECIFIED_TYPE")]
        UNSPECIFIED_TYPE


    } // enum ProductType

} // namespace Rubrik.SecurityCloud.Types