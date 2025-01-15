// AksNodeCountBucket.cs
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
    public enum AksNodeCountBucket
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "AKS_NODE_COUNT_BUCKET_LARGE")]
        AKS_NODE_COUNT_BUCKET_LARGE,

        [EnumMember(Value = "AKS_NODE_COUNT_BUCKET_MEDIUM")]
        AKS_NODE_COUNT_BUCKET_MEDIUM,

        [EnumMember(Value = "AKS_NODE_COUNT_BUCKET_SMALL")]
        AKS_NODE_COUNT_BUCKET_SMALL,

        [EnumMember(Value = "AKS_NODE_COUNT_BUCKET_UNSPECIFIED")]
        AKS_NODE_COUNT_BUCKET_UNSPECIFIED,

        [EnumMember(Value = "AKS_NODE_COUNT_BUCKET_XLARGE")]
        AKS_NODE_COUNT_BUCKET_XLARGE


    } // enum AksNodeCountBucket

} // namespace RubrikSecurityCloud.Types