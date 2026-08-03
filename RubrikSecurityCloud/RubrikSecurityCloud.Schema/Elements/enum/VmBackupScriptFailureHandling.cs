// VmBackupScriptFailureHandling.cs
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
    public enum VmBackupScriptFailureHandling
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "VM_BACKUP_SCRIPT_FAILURE_HANDLING_ABORT")]
        VM_BACKUP_SCRIPT_FAILURE_HANDLING_ABORT,

        [EnumMember(Value = "VM_BACKUP_SCRIPT_FAILURE_HANDLING_CONTINUE")]
        VM_BACKUP_SCRIPT_FAILURE_HANDLING_CONTINUE


    } // enum VmBackupScriptFailureHandling

} // namespace RubrikSecurityCloud.Types