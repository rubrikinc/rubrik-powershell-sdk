// ShareAssignStatus.cs
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
    public enum ShareAssignStatus
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "SHARE_ASSIGN_STATUS_ALREADY_ASSIGNED")]
        SHARE_ASSIGN_STATUS_ALREADY_ASSIGNED,

        [EnumMember(Value = "SHARE_ASSIGN_STATUS_INTERNAL_ERROR")]
        SHARE_ASSIGN_STATUS_INTERNAL_ERROR,

        [EnumMember(Value = "SHARE_ASSIGN_STATUS_NOT_FOUND")]
        SHARE_ASSIGN_STATUS_NOT_FOUND,

        [EnumMember(Value = "SHARE_ASSIGN_STATUS_PERMISSION_DENIED")]
        SHARE_ASSIGN_STATUS_PERMISSION_DENIED,

        [EnumMember(Value = "SHARE_ASSIGN_STATUS_SUCCESS")]
        SHARE_ASSIGN_STATUS_SUCCESS,

        [EnumMember(Value = "SHARE_ASSIGN_STATUS_UNSPECIFIED")]
        SHARE_ASSIGN_STATUS_UNSPECIFIED


    } // enum ShareAssignStatus

} // namespace RubrikSecurityCloud.Types