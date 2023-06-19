// WorkloadAnomaliesSortBy.cs
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
    public enum WorkloadAnomaliesSortBy
    {
        [EnumMember(Value = "CREATED_FILE_COUNT")]
        CREATED_FILE_COUNT,

        [EnumMember(Value = "DELETED_FILE_COUNT")]
        DELETED_FILE_COUNT,

        [EnumMember(Value = "ENCRYPTION")]
        ENCRYPTION,

        [EnumMember(Value = "MODIFIED_FILE_COUNT")]
        MODIFIED_FILE_COUNT,

        [EnumMember(Value = "NAME")]
        NAME,

        [EnumMember(Value = "SENSITIVE_FILES")]
        SENSITIVE_FILES,

        [EnumMember(Value = "SENSITIVE_HITS")]
        SENSITIVE_HITS,

        [EnumMember(Value = "SEVERITY")]
        SEVERITY,

        [EnumMember(Value = "SNAPSHOT_DATE")]
        SNAPSHOT_DATE,

        [EnumMember(Value = "SUSPICIOUS_FILE_COUNT")]
        SUSPICIOUS_FILE_COUNT


    } // enum WorkloadAnomaliesSortBy

} // namespace RubrikSecurityCloud.Types