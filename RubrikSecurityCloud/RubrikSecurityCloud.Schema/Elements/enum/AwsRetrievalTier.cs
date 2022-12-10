// AwsRetrievalTier.cs
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
    public enum AwsRetrievalTier
    {
        [EnumMember(Value = "BULK_TIER")]
        BULK_TIER,

        [EnumMember(Value = "EXPEDITED_TIER")]
        EXPEDITED_TIER,

        [EnumMember(Value = "STANDARD_TIER")]
        STANDARD_TIER


    } // enum AwsRetrievalTier

} // namespace Rubrik.SecurityCloud.Types