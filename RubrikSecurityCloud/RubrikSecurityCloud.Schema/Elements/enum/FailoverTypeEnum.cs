// FailoverTypeEnum.cs
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
    public enum FailoverTypeEnum
    {
        [EnumMember(Value = "FAILOVER")]
        FAILOVER,

        [EnumMember(Value = "ISOLATED_RECOVERY")]
        ISOLATED_RECOVERY,

        [EnumMember(Value = "LOCALRECOVERY")]
        LOCALRECOVERY,

        [EnumMember(Value = "TEST_FAILOVER")]
        TEST_FAILOVER,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN


    } // enum FailoverTypeEnum

} // namespace RubrikSecurityCloud.Types