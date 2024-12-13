// CloudNativeRbaStatusType.cs
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
    public enum CloudNativeRbaStatusType
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "NOT_REGISTERED")]
        NOT_REGISTERED,

        [EnumMember(Value = "REGISTERED")]
        REGISTERED,

        [EnumMember(Value = "UNAVAILABLE")]
        UNAVAILABLE


    } // enum CloudNativeRbaStatusType

} // namespace RubrikSecurityCloud.Types