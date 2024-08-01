// WarningSeverityEnum.cs
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
    public enum WarningSeverityEnum
    {
        [EnumMember(Value = "BLOCKING")]
        BLOCKING,

        [EnumMember(Value = "NONE")]
        NONE,

        [EnumMember(Value = "NON_BLOCKING")]
        NON_BLOCKING,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN


    } // enum WarningSeverityEnum

} // namespace RubrikSecurityCloud.Types