// ColossusStorageContainerImmutabilityStatus.cs
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
    public enum ColossusStorageContainerImmutabilityStatus
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "DISABLED")]
        DISABLED,

        [EnumMember(Value = "ENABLED")]
        ENABLED,

        [EnumMember(Value = "MIGRATION_IN_PROGRESS")]
        MIGRATION_IN_PROGRESS,

        [EnumMember(Value = "STATUS_UNSPECIFIED")]
        STATUS_UNSPECIFIED


    } // enum ColossusStorageContainerImmutabilityStatus

} // namespace RubrikSecurityCloud.Types