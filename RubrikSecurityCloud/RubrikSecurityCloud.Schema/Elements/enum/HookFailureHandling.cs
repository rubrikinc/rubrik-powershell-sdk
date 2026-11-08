// HookFailureHandling.cs
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
    public enum HookFailureHandling
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "ABORT_RECOVERY_ON_FAILURE")]
        ABORT_RECOVERY_ON_FAILURE,

        [EnumMember(Value = "IGNORE_FAILURE_AND_PROCEED")]
        IGNORE_FAILURE_AND_PROCEED


    } // enum HookFailureHandling

} // namespace RubrikSecurityCloud.Types