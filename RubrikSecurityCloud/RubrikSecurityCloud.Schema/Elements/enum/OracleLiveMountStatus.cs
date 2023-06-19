// OracleLiveMountStatus.cs
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
    public enum OracleLiveMountStatus
    {
        [EnumMember(Value = "AVAILABLE")]
        AVAILABLE,

        [EnumMember(Value = "MOUNTING")]
        MOUNTING,

        [EnumMember(Value = "UNAVAILABLE")]
        UNAVAILABLE,

        [EnumMember(Value = "UNMOUNTING")]
        UNMOUNTING


    } // enum OracleLiveMountStatus

} // namespace RubrikSecurityCloud.Types