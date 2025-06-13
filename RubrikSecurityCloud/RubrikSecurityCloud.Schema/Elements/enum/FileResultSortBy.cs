// FileResultSortBy.cs
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
    public enum FileResultSortBy
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "CLUSTER")]
        CLUSTER,

        [EnumMember(Value = "CREATION_TIME")]
        CREATION_TIME,

        [EnumMember(Value = "DAILY_CHANGE")]
        DAILY_CHANGE,

        [EnumMember(Value = "DATA_CATEGORY")]
        DATA_CATEGORY,

        [EnumMember(Value = "DATA_TYPE")]
        DATA_TYPE,

        [EnumMember(Value = "DOCUMENT_TYPE")]
        DOCUMENT_TYPE,

        [EnumMember(Value = "EXPOSED_FILES")]
        EXPOSED_FILES,

        [EnumMember(Value = "FILES_WITH_HITS")]
        FILES_WITH_HITS,

        [EnumMember(Value = "FILES_WITH_OPEN_ACCESS_HITS")]
        FILES_WITH_OPEN_ACCESS_HITS,

        [EnumMember(Value = "HITS")]
        HITS,

        [EnumMember(Value = "HITS_BY_SENSITIVITY")]
        HITS_BY_SENSITIVITY,

        [EnumMember(Value = "LAST_ACCESS_TIME")]
        LAST_ACCESS_TIME,

        [EnumMember(Value = "LAST_MODIFIED")]
        LAST_MODIFIED,

        [EnumMember(Value = "LAST_SCAN_TIME")]
        LAST_SCAN_TIME,

        [EnumMember(Value = "NAME")]
        NAME,

        [EnumMember(Value = "NATIVE_PATH")]
        NATIVE_PATH,

        [EnumMember(Value = "NUM_ACTIVITIES")]
        NUM_ACTIVITIES,

        [EnumMember(Value = "NUM_ACTIVITIES_DELTA")]
        NUM_ACTIVITIES_DELTA,

        [EnumMember(Value = "OBJECT_LOCATION")]
        OBJECT_LOCATION,

        [EnumMember(Value = "OBJECT_NAME")]
        OBJECT_NAME,

        [EnumMember(Value = "OPEN_ACCESS_TYPE")]
        OPEN_ACCESS_TYPE,

        [EnumMember(Value = "SNAPSHOT_TIME")]
        SNAPSHOT_TIME,

        [EnumMember(Value = "STALE_FILES_WITH_HITS")]
        STALE_FILES_WITH_HITS,

        [EnumMember(Value = "TOTAL_SENSITIVE_HITS")]
        TOTAL_SENSITIVE_HITS


    } // enum FileResultSortBy

} // namespace RubrikSecurityCloud.Types