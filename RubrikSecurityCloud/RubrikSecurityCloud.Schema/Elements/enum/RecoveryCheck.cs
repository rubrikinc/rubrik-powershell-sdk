// RecoveryCheck.cs
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
    public enum RecoveryCheck
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "BUCKET_ACCESS_DENIED")]
        BUCKET_ACCESS_DENIED,

        [EnumMember(Value = "CDC_COVERAGE_GAP")]
        CDC_COVERAGE_GAP,

        [EnumMember(Value = "CERT_TARBALL_MISSING")]
        CERT_TARBALL_MISSING,

        [EnumMember(Value = "DATA_LOCATION_ID_INVALID")]
        DATA_LOCATION_ID_INVALID,

        [EnumMember(Value = "NODE_NOT_TERMINATED")]
        NODE_NOT_TERMINATED,

        [EnumMember(Value = "NODE_STATE_UNKNOWN")]
        NODE_STATE_UNKNOWN,

        [EnumMember(Value = "SHARD_INCOMPLETE")]
        SHARD_INCOMPLETE,

        [EnumMember(Value = "SNAPSHOT_MISSING")]
        SNAPSHOT_MISSING,

        [EnumMember(Value = "SNAPSHOT_STALE")]
        SNAPSHOT_STALE,

        [EnumMember(Value = "UNSPECIFIED")]
        UNSPECIFIED


    } // enum RecoveryCheck

} // namespace RubrikSecurityCloud.Types