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

namespace Rubrik.SecurityCloud.Types
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
        TEST_FAILOVER


    } // enum FailoverTypeEnum

} // namespace Rubrik.SecurityCloud.Types