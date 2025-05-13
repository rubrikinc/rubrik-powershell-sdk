// PendingObjectPauseAssignmentStatus.cs
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
    public enum PendingObjectPauseAssignmentStatus
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "NO_PENDING_PAUSE_ASSIGNMENT")]
        NO_PENDING_PAUSE_ASSIGNMENT,

        [EnumMember(Value = "PAUSE")]
        PAUSE,

        [EnumMember(Value = "UNPAUSE")]
        UNPAUSE


    } // enum PendingObjectPauseAssignmentStatus

} // namespace RubrikSecurityCloud.Types