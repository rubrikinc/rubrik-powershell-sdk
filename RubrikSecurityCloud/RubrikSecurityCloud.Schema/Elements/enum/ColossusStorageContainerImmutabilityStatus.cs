// ColossusStorageContainerImmutabilityStatus.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:04:32.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace Rubrik.SecurityCloud.Types
{
    public enum ColossusStorageContainerImmutabilityStatus
    {
        [EnumMember(Value = "DISABLED")]
        DISABLED,

        [EnumMember(Value = "ENABLED")]
        ENABLED,

        [EnumMember(Value = "MIGRATION_IN_PROGRESS")]
        MIGRATION_IN_PROGRESS,

        [EnumMember(Value = "STATUS_UNSPECIFIED")]
        STATUS_UNSPECIFIED


    } // enum ColossusStorageContainerImmutabilityStatus

} // namespace Rubrik.SecurityCloud.Types