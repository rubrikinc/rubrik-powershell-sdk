// ArchivalLocationEncryptionHealthStatus.cs
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
    public enum ArchivalLocationEncryptionHealthStatus
    {
        [EnumMember(Value = "HEALTHY_ENCRYPTION_HEALTH_STATUS")]
        HEALTHY_ENCRYPTION_HEALTH_STATUS,

        [EnumMember(Value = "UNABLE_TO_DECRYPT_ENCRYPTION_HEALTH_STATUS")]
        UNABLE_TO_DECRYPT_ENCRYPTION_HEALTH_STATUS,

        [EnumMember(Value = "UNKNOWN_ENCRYPTION_HEALTH_STATUS")]
        UNKNOWN_ENCRYPTION_HEALTH_STATUS,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN


    } // enum ArchivalLocationEncryptionHealthStatus

} // namespace RubrikSecurityCloud.Types