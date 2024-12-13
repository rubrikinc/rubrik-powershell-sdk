// ContextFilterTypeEnum.cs
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
    public enum ContextFilterTypeEnum
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "APPFLOWS_FAILOVER_TO_AWS")]
        APPFLOWS_FAILOVER_TO_AWS,

        [EnumMember(Value = "APPFLOWS_FAILOVER_TO_CDM")]
        APPFLOWS_FAILOVER_TO_CDM,

        [EnumMember(Value = "DEFAULT")]
        DEFAULT


    } // enum ContextFilterTypeEnum

} // namespace RubrikSecurityCloud.Types