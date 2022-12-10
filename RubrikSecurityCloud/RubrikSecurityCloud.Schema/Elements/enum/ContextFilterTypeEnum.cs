// ContextFilterTypeEnum.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:23.
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
    public enum ContextFilterTypeEnum
    {
        [EnumMember(Value = "APPFLOWS_FAILOVER_TO_AWS")]
        APPFLOWS_FAILOVER_TO_AWS,

        [EnumMember(Value = "APPFLOWS_FAILOVER_TO_CDM")]
        APPFLOWS_FAILOVER_TO_CDM,

        [EnumMember(Value = "DEFAULT")]
        DEFAULT


    } // enum ContextFilterTypeEnum

} // namespace Rubrik.SecurityCloud.Types