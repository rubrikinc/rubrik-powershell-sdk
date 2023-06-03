// NewCasePriority.cs
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
    public enum NewCasePriority
    {
        [EnumMember(Value = "CASE_PRIORITY_UNSPECIFIED")]
        CASE_PRIORITY_UNSPECIFIED,

        [EnumMember(Value = "P1")]
        P1,

        [EnumMember(Value = "P2")]
        P2,

        [EnumMember(Value = "P3")]
        P3,

        [EnumMember(Value = "P4")]
        P4


    } // enum NewCasePriority

} // namespace Rubrik.SecurityCloud.Types