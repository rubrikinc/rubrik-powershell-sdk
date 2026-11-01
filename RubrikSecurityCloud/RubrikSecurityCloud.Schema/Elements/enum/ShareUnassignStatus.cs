// ShareUnassignStatus.cs
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
    public enum ShareUnassignStatus
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "SHARE_UNASSIGN_STATUS_INTERNAL_ERROR")]
        SHARE_UNASSIGN_STATUS_INTERNAL_ERROR,

        [EnumMember(Value = "SHARE_UNASSIGN_STATUS_IN_USE")]
        SHARE_UNASSIGN_STATUS_IN_USE,

        [EnumMember(Value = "SHARE_UNASSIGN_STATUS_NOT_ASSIGNED")]
        SHARE_UNASSIGN_STATUS_NOT_ASSIGNED,

        [EnumMember(Value = "SHARE_UNASSIGN_STATUS_PERMISSION_DENIED")]
        SHARE_UNASSIGN_STATUS_PERMISSION_DENIED,

        [EnumMember(Value = "SHARE_UNASSIGN_STATUS_SCHEDULE_NOT_FOUND")]
        SHARE_UNASSIGN_STATUS_SCHEDULE_NOT_FOUND,

        [EnumMember(Value = "SHARE_UNASSIGN_STATUS_SHARE_NOT_FOUND")]
        SHARE_UNASSIGN_STATUS_SHARE_NOT_FOUND,

        [EnumMember(Value = "SHARE_UNASSIGN_STATUS_SUCCESS")]
        SHARE_UNASSIGN_STATUS_SUCCESS,

        [EnumMember(Value = "SHARE_UNASSIGN_STATUS_UNSPECIFIED")]
        SHARE_UNASSIGN_STATUS_UNSPECIFIED


    } // enum ShareUnassignStatus

} // namespace RubrikSecurityCloud.Types