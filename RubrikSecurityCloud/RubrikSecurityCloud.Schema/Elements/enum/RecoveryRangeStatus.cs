// RecoveryRangeStatus.cs
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
    public enum RecoveryRangeStatus
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "NOT_RECOVERABLE_DUE_TO_BACKUP_FAILURE")]
        NOT_RECOVERABLE_DUE_TO_BACKUP_FAILURE,

        [EnumMember(Value = "NOT_RECOVERABLE_DUE_TO_OTHER_REASON")]
        NOT_RECOVERABLE_DUE_TO_OTHER_REASON,

        [EnumMember(Value = "NOT_RECOVERABLE_DUE_TO_PROCESSING")]
        NOT_RECOVERABLE_DUE_TO_PROCESSING,

        [EnumMember(Value = "NOT_RECOVERABLE_DUE_TO_QUARANTINE")]
        NOT_RECOVERABLE_DUE_TO_QUARANTINE,

        [EnumMember(Value = "RECOVERABLE")]
        RECOVERABLE,

        [EnumMember(Value = "UNSPECIFIED")]
        UNSPECIFIED


    } // enum RecoveryRangeStatus

} // namespace RubrikSecurityCloud.Types