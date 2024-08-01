// CloudNativeLiveMountSortByFields.cs
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
    public enum CloudNativeLiveMountSortByFields
    {
        [EnumMember(Value = "FIELD_UNSPECIFIED")]
        FIELD_UNSPECIFIED,

        [EnumMember(Value = "MOUNT_TIME")]
        MOUNT_TIME,

        [EnumMember(Value = "SNAPSHOT_TIME")]
        SNAPSHOT_TIME,

        [EnumMember(Value = "SOURCE_VM_NAME")]
        SOURCE_VM_NAME,

        [EnumMember(Value = "TARGET_VM_NAME")]
        TARGET_VM_NAME,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN


    } // enum CloudNativeLiveMountSortByFields

} // namespace RubrikSecurityCloud.Types