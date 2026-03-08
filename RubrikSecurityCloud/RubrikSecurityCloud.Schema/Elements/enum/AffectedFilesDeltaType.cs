// AffectedFilesDeltaType.cs
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
    public enum AffectedFilesDeltaType
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "AFFECTED_FILES_DELTA_TYPE_ADDED")]
        AFFECTED_FILES_DELTA_TYPE_ADDED,

        [EnumMember(Value = "AFFECTED_FILES_DELTA_TYPE_DELETED")]
        AFFECTED_FILES_DELTA_TYPE_DELETED,

        [EnumMember(Value = "AFFECTED_FILES_DELTA_TYPE_MODIFIED")]
        AFFECTED_FILES_DELTA_TYPE_MODIFIED,

        [EnumMember(Value = "AFFECTED_FILES_DELTA_TYPE_RANSOMWARE_NOTE")]
        AFFECTED_FILES_DELTA_TYPE_RANSOMWARE_NOTE,

        [EnumMember(Value = "AFFECTED_FILES_DELTA_TYPE_SUSPICIOUS")]
        AFFECTED_FILES_DELTA_TYPE_SUSPICIOUS


    } // enum AffectedFilesDeltaType

} // namespace RubrikSecurityCloud.Types