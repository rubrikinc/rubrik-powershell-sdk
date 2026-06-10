// RecoveryFailureAction.cs
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
    public enum RecoveryFailureAction
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "CLEANUP")]
        CLEANUP,

        [EnumMember(Value = "IGNORE")]
        IGNORE,

        [EnumMember(Value = "PAUSE")]
        PAUSE,

        [EnumMember(Value = "UNSPECIFIED")]
        UNSPECIFIED


    } // enum RecoveryFailureAction

} // namespace RubrikSecurityCloud.Types