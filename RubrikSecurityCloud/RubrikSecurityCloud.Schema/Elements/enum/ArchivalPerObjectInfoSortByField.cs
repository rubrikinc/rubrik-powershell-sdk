// ArchivalPerObjectInfoSortByField.cs
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
    public enum ArchivalPerObjectInfoSortByField
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "ARCHIVAL_LAG")]
        ARCHIVAL_LAG,

        [EnumMember(Value = "ARCHIVAL_STORAGE")]
        ARCHIVAL_STORAGE,

        [EnumMember(Value = "NUM_ACTIVE_SNAPSHOTS")]
        NUM_ACTIVE_SNAPSHOTS,

        [EnumMember(Value = "OBJECT_NAME")]
        OBJECT_NAME,

        [EnumMember(Value = "SORT_BY_FIELD_UNSPECIFIED")]
        SORT_BY_FIELD_UNSPECIFIED


    } // enum ArchivalPerObjectInfoSortByField

} // namespace RubrikSecurityCloud.Types