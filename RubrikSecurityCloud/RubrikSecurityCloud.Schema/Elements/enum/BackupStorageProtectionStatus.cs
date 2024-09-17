// BackupStorageProtectionStatus.cs
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
    public enum BackupStorageProtectionStatus
    {
        [EnumMember(Value = "STATUS_PROTECTED")]
        STATUS_PROTECTED,

        [EnumMember(Value = "STATUS_PROTECT_REQUESTED")]
        STATUS_PROTECT_REQUESTED,

        [EnumMember(Value = "STATUS_REMOVE_REQUESTED")]
        STATUS_REMOVE_REQUESTED,

        [EnumMember(Value = "STATUS_UNPROTECTED")]
        STATUS_UNPROTECTED,

        [EnumMember(Value = "STATUS_UNPROTECT_REQUESTED")]
        STATUS_UNPROTECT_REQUESTED,

        [EnumMember(Value = "STATUS_UNSPECIFIED")]
        STATUS_UNSPECIFIED,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN


    } // enum BackupStorageProtectionStatus

} // namespace RubrikSecurityCloud.Types