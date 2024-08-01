// AppBlueprintFailoverStatus.cs
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
    public enum AppBlueprintFailoverStatus
    {
        [EnumMember(Value = "CleanupInProgress")]
        CLEANUP_IN_PROGRESS,

        [EnumMember(Value = "InProgress")]
        IN_PROGRESS,

        [EnumMember(Value = "Paused")]
        PAUSED,

        [EnumMember(Value = "Ready")]
        READY,

        [EnumMember(Value = "TestCleanupInProgress")]
        TEST_CLEANUP_IN_PROGRESS,

        [EnumMember(Value = "TestInProgress")]
        TEST_IN_PROGRESS,

        [EnumMember(Value = "TestPaused")]
        TEST_PAUSED,

        [EnumMember(Value = "TestPending")]
        TEST_PENDING,

        [EnumMember(Value = "Tested")]
        TESTED,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN


    } // enum AppBlueprintFailoverStatus

} // namespace RubrikSecurityCloud.Types