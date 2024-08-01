// AzureRetrievalTier.cs
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
    public enum AzureRetrievalTier
    {
        [EnumMember(Value = "AZURE_TIER_UNSPECIFIED")]
        AZURE_TIER_UNSPECIFIED,

        [EnumMember(Value = "HIGH_PRIORITY_AZURE_TIER")]
        HIGH_PRIORITY_AZURE_TIER,

        [EnumMember(Value = "STANDARD_AZURE_TIER")]
        STANDARD_AZURE_TIER,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN


    } // enum AzureRetrievalTier

} // namespace RubrikSecurityCloud.Types