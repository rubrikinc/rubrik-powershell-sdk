// SnapshotServiceBackupStatus.cs
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
    public enum SnapshotServiceBackupStatus
    {
        [EnumMember(Value = "FAIL")]
        FAIL,

        [EnumMember(Value = "FULL_SUCCESS")]
        FULL_SUCCESS,

        [EnumMember(Value = "PARTIAL_SUCCESS")]
        PARTIAL_SUCCESS


    } // enum SnapshotServiceBackupStatus

} // namespace RubrikSecurityCloud.Types