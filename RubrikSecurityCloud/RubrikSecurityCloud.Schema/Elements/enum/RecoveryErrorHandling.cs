// RecoveryErrorHandling.cs
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
    public enum RecoveryErrorHandling
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "ABORT_AND_CLEANUP")]
        ABORT_AND_CLEANUP,

        [EnumMember(Value = "PAUSE_ON_ERROR")]
        PAUSE_ON_ERROR


    } // enum RecoveryErrorHandling

} // namespace RubrikSecurityCloud.Types