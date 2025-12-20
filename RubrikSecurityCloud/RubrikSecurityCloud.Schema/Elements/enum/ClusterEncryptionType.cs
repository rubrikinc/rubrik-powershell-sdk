// ClusterEncryptionType.cs
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
    public enum ClusterEncryptionType
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "ENCRYPTION_TYPE_UNSPECIFIED")]
        ENCRYPTION_TYPE_UNSPECIFIED,

        [EnumMember(Value = "HARDWARE")]
        HARDWARE,

        [EnumMember(Value = "NOT_ENCRYPTED")]
        NOT_ENCRYPTED,

        [EnumMember(Value = "SOFTWARE")]
        SOFTWARE


    } // enum ClusterEncryptionType

} // namespace RubrikSecurityCloud.Types