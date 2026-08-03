// PendingBackupWindowAssignmentStatus.cs
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
    public enum PendingBackupWindowAssignmentStatus
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "NO_PENDING_BACKUP_WINDOW_ASSIGNMENT")]
        NO_PENDING_BACKUP_WINDOW_ASSIGNMENT,

        [EnumMember(Value = "PENDING_ASSIGNMENT")]
        PENDING_ASSIGNMENT


    } // enum PendingBackupWindowAssignmentStatus

} // namespace RubrikSecurityCloud.Types