// NutanixBackupScriptFailureHandling.cs
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
    public enum NutanixBackupScriptFailureHandling
    {
        [EnumMember(Value = "ABORT")]
        ABORT,

        [EnumMember(Value = "CONTINUE")]
        CONTINUE,

        [EnumMember(Value = "UNKNOWN_FAILURE_HANDLING")]
        UNKNOWN_FAILURE_HANDLING


    } // enum NutanixBackupScriptFailureHandling

} // namespace RubrikSecurityCloud.Types