// AwsRetrievalTier.cs
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
    public enum AwsRetrievalTier
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "BULK_TIER")]
        BULK_TIER,

        [EnumMember(Value = "EXPEDITED_TIER")]
        EXPEDITED_TIER,

        [EnumMember(Value = "STANDARD_TIER")]
        STANDARD_TIER


    } // enum AwsRetrievalTier

} // namespace RubrikSecurityCloud.Types