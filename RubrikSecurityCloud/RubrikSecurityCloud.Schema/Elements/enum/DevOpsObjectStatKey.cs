// DevOpsObjectStatKey.cs
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
    public enum DevOpsObjectStatKey
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "BYTES_STORED")]
        BYTES_STORED,

        [EnumMember(Value = "LATEST_SNAPSHOT_AT")]
        LATEST_SNAPSHOT_AT,

        [EnumMember(Value = "NUM_ADO_WIKIS")]
        NUM_ADO_WIKIS,

        [EnumMember(Value = "NUM_ADO_WORK_ITEMS")]
        NUM_ADO_WORK_ITEMS,

        [EnumMember(Value = "NUM_GITHUB_ISSUES")]
        NUM_GITHUB_ISSUES,

        [EnumMember(Value = "NUM_GITHUB_PULL_REQUESTS")]
        NUM_GITHUB_PULL_REQUESTS,

        [EnumMember(Value = "OLDEST_SNAPSHOT_AT")]
        OLDEST_SNAPSHOT_AT


    } // enum DevOpsObjectStatKey

} // namespace RubrikSecurityCloud.Types