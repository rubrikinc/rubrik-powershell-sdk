// NutanixBackupScriptFailureHandling.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:50.
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
    public enum NutanixBackupScriptFailureHandling
    {
        [EnumMember(Value = "ABORT")]
        ABORT,

        [EnumMember(Value = "CONTINUE")]
        CONTINUE,

        [EnumMember(Value = "UNKNOWN_FAILURE_HANDLING")]
        UNKNOWN_FAILURE_HANDLING


    } // enum NutanixBackupScriptFailureHandling

} // namespace Rubrik.SecurityCloud.Types