// RecoveryType.cs
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
    public enum RecoveryType
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "CYBER")]
        CYBER,

        [EnumMember(Value = "FAILOVER")]
        FAILOVER,

        [EnumMember(Value = "INPLACE")]
        INPLACE,

        [EnumMember(Value = "TEST_FAILOVER")]
        TEST_FAILOVER


    } // enum RecoveryType

} // namespace RubrikSecurityCloud.Types