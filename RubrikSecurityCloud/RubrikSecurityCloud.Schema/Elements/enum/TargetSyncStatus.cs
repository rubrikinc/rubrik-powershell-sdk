// TargetSyncStatus.cs
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
    public enum TargetSyncStatus
    {
        [EnumMember(Value = "ACTION_FAILED")]
        ACTION_FAILED,

        [EnumMember(Value = "ACTION_FAILED_RETRY")]
        ACTION_FAILED_RETRY,

        [EnumMember(Value = "NOT_CREATED_ON_CDM")]
        NOT_CREATED_ON_CDM,

        [EnumMember(Value = "PENDING_PROMOTE")]
        PENDING_PROMOTE,

        [EnumMember(Value = "PENDING_REFRESH")]
        PENDING_REFRESH,

        [EnumMember(Value = "PENDING_SYNC")]
        PENDING_SYNC,

        [EnumMember(Value = "SYNCED")]
        SYNCED


    } // enum TargetSyncStatus

} // namespace RubrikSecurityCloud.Types