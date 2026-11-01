// WorkflowProtectionStatus.cs
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
    public enum WorkflowProtectionStatus
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "DISCOVERED")]
        DISCOVERED,

        [EnumMember(Value = "FAILED")]
        FAILED,

        [EnumMember(Value = "PROTECTED")]
        PROTECTED,

        [EnumMember(Value = "UNCONFIGURED")]
        UNCONFIGURED


    } // enum WorkflowProtectionStatus

} // namespace RubrikSecurityCloud.Types