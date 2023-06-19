// BlueprintStatus.cs
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
    public enum BlueprintStatus
    {
        [EnumMember(Value = "CONFIGURED")]
        CONFIGURED,

        [EnumMember(Value = "INCOMPLETE")]
        INCOMPLETE,

        [EnumMember(Value = "INVALID")]
        INVALID,

        [EnumMember(Value = "MISSING_CHILDREN")]
        MISSING_CHILDREN,

        [EnumMember(Value = "NOT_CONFIGURED")]
        NOT_CONFIGURED


    } // enum BlueprintStatus

} // namespace RubrikSecurityCloud.Types