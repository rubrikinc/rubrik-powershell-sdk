// ObjectSummariesSortByFields.cs
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
    public enum ObjectSummariesSortByFields
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "EARLIEST_MATCHED_SNAPSHOT")]
        EARLIEST_MATCHED_SNAPSHOT,

        [EnumMember(Value = "FILE_MATCHES")]
        FILE_MATCHES,

        [EnumMember(Value = "IOC_MATCHES")]
        IOC_MATCHES,

        [EnumMember(Value = "LATEST_MATCHED_SNAPSHOT")]
        LATEST_MATCHED_SNAPSHOT,

        [EnumMember(Value = "LATEST_UNMATCHED_SNAPSHOT")]
        LATEST_UNMATCHED_SNAPSHOT,

        [EnumMember(Value = "MATCHED_SNAPSHOTS")]
        MATCHED_SNAPSHOTS,

        [EnumMember(Value = "MATCH_TYPE")]
        MATCH_TYPE,

        [EnumMember(Value = "OBJECT_NAME")]
        OBJECT_NAME


    } // enum ObjectSummariesSortByFields

} // namespace RubrikSecurityCloud.Types