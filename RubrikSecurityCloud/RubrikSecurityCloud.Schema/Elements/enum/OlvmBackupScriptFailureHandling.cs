// OlvmBackupScriptFailureHandling.cs
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
    public enum OlvmBackupScriptFailureHandling
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "OLVM_BACKUP_SCRIPT_FAILURE_HANDLING_ABORT")]
        OLVM_BACKUP_SCRIPT_FAILURE_HANDLING_ABORT,

        [EnumMember(Value = "OLVM_BACKUP_SCRIPT_FAILURE_HANDLING_CONTINUE")]
        OLVM_BACKUP_SCRIPT_FAILURE_HANDLING_CONTINUE,

        [EnumMember(Value = "OLVM_BACKUP_SCRIPT_FAILURE_HANDLING_UNSPECIFIED")]
        OLVM_BACKUP_SCRIPT_FAILURE_HANDLING_UNSPECIFIED


    } // enum OlvmBackupScriptFailureHandling

} // namespace RubrikSecurityCloud.Types