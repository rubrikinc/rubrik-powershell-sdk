// RecoveryCommitStatus.cs
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
    public enum RecoveryCommitStatus
    {
        [EnumMember(Value = "COMMITTED")]
        COMMITTED,

        [EnumMember(Value = "COMMIT_INCOMPLETE")]
        COMMIT_INCOMPLETE,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN


    } // enum RecoveryCommitStatus

} // namespace RubrikSecurityCloud.Types