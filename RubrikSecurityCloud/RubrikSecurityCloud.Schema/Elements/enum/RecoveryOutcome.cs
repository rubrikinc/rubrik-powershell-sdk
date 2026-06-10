// RecoveryOutcome.cs
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
    public enum RecoveryOutcome
    {
        [EnumMember(Value = "FAILED")]
        FAILED,

        [EnumMember(Value = "PARTIALLY_SUCCEEDED")]
        PARTIALLY_SUCCEEDED,

        [EnumMember(Value = "SUCCEEDED")]
        SUCCEEDED,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN


    } // enum RecoveryOutcome

} // namespace RubrikSecurityCloud.Types