// GcpBucketNetworkAccess.cs
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
    public enum GcpBucketNetworkAccess
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "GCP_BUCKET_PRIVATE")]
        GCP_BUCKET_PRIVATE,

        [EnumMember(Value = "GCP_BUCKET_PUBLIC")]
        GCP_BUCKET_PUBLIC,

        [EnumMember(Value = "UNKNOWN_GCP_BUCKET_NETWORK_ACCESS")]
        UNKNOWN_GCP_BUCKET_NETWORK_ACCESS


    } // enum GcpBucketNetworkAccess

} // namespace RubrikSecurityCloud.Types