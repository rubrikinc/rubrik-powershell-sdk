// AzureRetrievalTier.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:04:19.
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
    public enum AzureRetrievalTier
    {
        [EnumMember(Value = "AZURE_TIER_UNSPECIFIED")]
        AZURE_TIER_UNSPECIFIED,

        [EnumMember(Value = "HIGH_PRIORITY_AZURE_TIER")]
        HIGH_PRIORITY_AZURE_TIER,

        [EnumMember(Value = "STANDARD_AZURE_TIER")]
        STANDARD_AZURE_TIER


    } // enum AzureRetrievalTier

} // namespace Rubrik.SecurityCloud.Types