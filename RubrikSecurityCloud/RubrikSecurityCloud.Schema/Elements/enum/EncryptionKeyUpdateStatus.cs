// EncryptionKeyUpdateStatus.cs
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
    public enum EncryptionKeyUpdateStatus
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "FAILURE")]
        FAILURE,

        [EnumMember(Value = "INVALID_ENCRYPTION_KEY")]
        INVALID_ENCRYPTION_KEY,

        [EnumMember(Value = "NO_MIGRATION_IN_PROGRESS")]
        NO_MIGRATION_IN_PROGRESS,

        [EnumMember(Value = "SUCCESS")]
        SUCCESS,

        [EnumMember(Value = "UPDATE_STATUS_UNSPECIFIED")]
        UPDATE_STATUS_UNSPECIFIED


    } // enum EncryptionKeyUpdateStatus

} // namespace RubrikSecurityCloud.Types