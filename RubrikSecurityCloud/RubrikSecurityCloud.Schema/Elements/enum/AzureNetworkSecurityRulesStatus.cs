// AzureNetworkSecurityRulesStatus.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:55.
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
    public enum AzureNetworkSecurityRulesStatus
    {
        [EnumMember(Value = "BLOCKING")]
        BLOCKING,

        [EnumMember(Value = "GOOD")]
        GOOD,

        [EnumMember(Value = "MAYBE_BLOCKING")]
        MAYBE_BLOCKING


    } // enum AzureNetworkSecurityRulesStatus

} // namespace Rubrik.SecurityCloud.Types