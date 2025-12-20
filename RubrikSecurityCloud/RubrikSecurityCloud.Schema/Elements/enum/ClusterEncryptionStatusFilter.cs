// ClusterEncryptionStatusFilter.cs
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
    public enum ClusterEncryptionStatusFilter
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "CLUSTER_ENCRYPTION_STATUS_UNSPECIFIED")]
        CLUSTER_ENCRYPTION_STATUS_UNSPECIFIED,

        [EnumMember(Value = "ENCRYPTION_DISABLED")]
        ENCRYPTION_DISABLED,

        [EnumMember(Value = "ENCRYPTION_ENABLED")]
        ENCRYPTION_ENABLED


    } // enum ClusterEncryptionStatusFilter

} // namespace RubrikSecurityCloud.Types