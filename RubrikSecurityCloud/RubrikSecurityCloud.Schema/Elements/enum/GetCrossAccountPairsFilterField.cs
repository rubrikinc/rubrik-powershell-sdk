// GetCrossAccountPairsFilterField.cs
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
    public enum GetCrossAccountPairsFilterField
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "ACCOUNT_ROLE")]
        ACCOUNT_ROLE,

        [EnumMember(Value = "NAME")]
        NAME,

        [EnumMember(Value = "ORG_NAME")]
        ORG_NAME,

        [EnumMember(Value = "STATUS")]
        STATUS


    } // enum GetCrossAccountPairsFilterField

} // namespace RubrikSecurityCloud.Types