// TprExecutionType.cs
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
    public enum TprExecutionType
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "IMMEDIATE")]
        IMMEDIATE,

        [EnumMember(Value = "ON_DEMAND")]
        ON_DEMAND


    } // enum TprExecutionType

} // namespace RubrikSecurityCloud.Types