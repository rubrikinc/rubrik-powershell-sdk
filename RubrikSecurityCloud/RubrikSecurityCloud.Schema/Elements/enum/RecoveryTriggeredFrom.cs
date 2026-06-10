// RecoveryTriggeredFrom.cs
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
    public enum RecoveryTriggeredFrom
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "ORCHESTRATED_RECOVERY")]
        ORCHESTRATED_RECOVERY,

        [EnumMember(Value = "RANSOMWARE_MONITORING")]
        RANSOMWARE_MONITORING,

        [EnumMember(Value = "RECOVERY_SCHEDULER")]
        RECOVERY_SCHEDULER,

        [EnumMember(Value = "TRIGGER_UNSPECIFIED")]
        TRIGGER_UNSPECIFIED


    } // enum RecoveryTriggeredFrom

} // namespace RubrikSecurityCloud.Types