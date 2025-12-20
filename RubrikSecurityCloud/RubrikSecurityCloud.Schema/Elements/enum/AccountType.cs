// AccountType.cs
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
    public enum AccountType
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "POC")]
        POC,

        [EnumMember(Value = "REVENUE")]
        REVENUE,

        [EnumMember(Value = "SANDBOX")]
        SANDBOX,

        [EnumMember(Value = "TYPE_UNSPECIFIED")]
        TYPE_UNSPECIFIED


    } // enum AccountType

} // namespace RubrikSecurityCloud.Types