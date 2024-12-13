// ProductType.cs
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
    public enum ProductType
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "PAG_TRIAL")]
        PAG_TRIAL,

        [EnumMember(Value = "POC")]
        POC,

        [EnumMember(Value = "REVENUE")]
        REVENUE,

        [EnumMember(Value = "TRIAL")]
        TRIAL,

        [EnumMember(Value = "UNSPECIFIED_TYPE")]
        UNSPECIFIED_TYPE


    } // enum ProductType

} // namespace RubrikSecurityCloud.Types